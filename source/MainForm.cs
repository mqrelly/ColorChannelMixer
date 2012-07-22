using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ColorChannelMixer
{
    public partial class MainForm : Form
    {
        #region Constructor

        public MainForm()
        {
            InitializeComponent();

            this.Source1_ColorChannel_ComboBox.SelectedIndex = 0;
            this.Source2_ColorChannel_ComboBox.SelectedIndex = 1;
            this.Source3_ColorChannel_ComboBox.SelectedIndex = 2;
            this.UpdateSourceNumberGui();
        }

        #endregion

        #region Gui commands

        private void ColorChannel_ComboBox_DrawItem( object sender, DrawItemEventArgs e )
        {
            e.DrawBackground();

            Brush bg_brush;
            switch( e.Index )
            {
            case 0:
                bg_brush = Brushes.Red;
                break;

            case 1:
                bg_brush = Brushes.LightGreen;
                break;

            case 2:
                bg_brush = Brushes.Blue;
                break;

            default:
                return;
            }

            e.Graphics.FillRectangle(
                bg_brush,
                e.Bounds.Left + 2,
                e.Bounds.Top + 2,
                e.Bounds.Width - 4,
                e.Bounds.Height - 4);

            if( (e.State & DrawItemState.Focus) != 0 )
                e.DrawFocusRectangle();
        }

        private void SourceNumber_TrackBar_ValueChanged( object sender, EventArgs e )
        {
            this.UpdateSourceNumberGui();
        }

        private void UpdateSourceNumberGui()
        {
            switch( this.SourceNumber_TrackBar.Value )
            {
            case 1:
                this.Source2_Panel.Visible = false;
                this.Source3_Panel.Visible = false;
                break;

            case 2:
                this.Source2_Panel.Visible = true;
                this.Source3_Panel.Visible = false;
                break;

            case 3:
                this.Source2_Panel.Visible = true;
                this.Source3_Panel.Visible = true;
                break;

            default:
                throw new NotImplementedException(string.Format(
                    "Value '{0}' for SourceNumber not implemented.",
                    this.SourceNumber_TrackBar.Value));
            }
        }

        private void SetGuiEnabled( bool enabled )
        {
            this.SourceNumer_Panel.Enabled = enabled;
            this.Source1_Panel.Enabled = enabled;
            this.Source2_Panel.Enabled = enabled;
            this.Source3_Panel.Enabled = enabled;
            this.WorkingDirectory_Panel.Enabled = enabled;
        }

        #endregion

        #region User commands

        private void WorkingDirectory_Browser_Button_Click( object sender, EventArgs e )
        {
            if( this.WorkingDirectory_BrowserDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK )
            {
                this.WorkingDirectory_TextBox.Text = this.WorkingDirectory_BrowserDialog.SelectedPath;
            }
        }

        private void Process_Button_Click( object sender, EventArgs e )
        {
            if( this.Process_Worker.IsBusy )
            {
                this.Process_Worker.CancelAsync();
                this.Process_Button.Enabled = false;
            }
            else
            {
                this.Process_Start();
            }
        }

        #endregion

        #region Processing

        private class ProcessArguments
        {
            public string WorkingDir;
            public List<string[]> FileNames;
            public Color[] Filters;
        }

        private void Process_Start()
        {
            // Find images, pairs, or triplets.
            var patterns = new List<string>();
            var filters = new List<Color>();
            patterns.Add(this.Source1_FileNamePattern_TextBox.Text);
            filters.Add(ComboBoxSelectionToFilter(this.Source1_ColorChannel_ComboBox.SelectedIndex));
            if( this.SourceNumber_TrackBar.Value > 1 )
            {
                patterns.Add(this.Source2_FileNamePattern_TextBox.Text);
                filters.Add(ComboBoxSelectionToFilter(this.Source2_ColorChannel_ComboBox.SelectedIndex));
            }
            if( this.SourceNumber_TrackBar.Value > 2 )
            {
                patterns.Add(this.Source3_FileNamePattern_TextBox.Text);
                filters.Add(ComboBoxSelectionToFilter(this.Source3_ColorChannel_ComboBox.SelectedIndex));
            }

            var matching_file_names = MatchingFileNames.Find(
                this.WorkingDirectory_TextBox.Text, patterns.ToArray()).ToList();
            if( matching_file_names.Count == 0 )
            {
                MessageBox.Show(
                    this,
                    "Nem találtam megfelelő forrásképeket.",
                    "Figyelem",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            // Prepare Gui for the process
            this.SetGuiEnabled(false);
            this.Process_ProgressBar.Value = 0;
            this.Process_ProgressBar.Maximum = matching_file_names.Count;
            this.Process_ProgressBar.Visible = true;
            this.Process_Button.Text = "Megszakít";

            // Start worker thread with
            this.Process_Worker.RunWorkerAsync(new ProcessArguments()
                {
                    WorkingDir = this.WorkingDirectory_TextBox.Text,
                    FileNames = matching_file_names,
                    Filters = filters.ToArray(),
                });
        }

        private static Color ComboBoxSelectionToFilter( int selected_index )
        {
            switch( selected_index )
            {
            case 0: return Color.FromArgb(255, 0, 0);
            case 1: return Color.FromArgb(0, 255, 0);
            case 2: return Color.FromArgb(0, 0, 255);
            default:
                throw new NotImplementedException("Don't know how to conver selection other then [0,1,2].");
            }
        }

        private void Process_Worker_DoWork( object sender, System.ComponentModel.DoWorkEventArgs e )
        {
            var start_time = DateTime.UtcNow;
            var worker = sender as System.ComponentModel.BackgroundWorker;
            var args = e.Argument as ProcessArguments;
            int rslt_ind = args.FileNames[0].Length - 1;
            Bitmap result = null;
            for( int i = 0; i < args.FileNames.Count; ++i )
            {
                if( worker.CancellationPending )
                {
                    e.Cancel = true;
                    e.Result = (DateTime.UtcNow - start_time).TotalSeconds;
                    return;
                }

                var sources = new Bitmap[args.FileNames[i].Length - 1];
                try
                {
                    // Load source bitmaps
                    for( int j = 0; j < sources.Length; ++j )
                        sources[j] = (Bitmap)Bitmap.FromFile(System.IO.Path.Combine(
                            args.WorkingDir, args.FileNames[i][j]));

                    // Do the processing
                    ColorChannelMixer.ProcessImage_WithMarshal(sources, args.Filters, ref result);

                    // Save result image
                    result.Save(System.IO.Path.Combine(
                        args.WorkingDir, args.FileNames[i][rslt_ind]));

                    worker.ReportProgress(i);
                }
                catch( Exception ex )
                {
                    worker.ReportProgress(i, ex);
                }
                finally
                {
                    // Unload source bitmaps
                    for( int j = 0; j < sources.Length; ++j )
                        if( sources[j] != null )
                        {
                            sources[j].Dispose();
                            sources[j] = null;
                        }
                }
            }
            e.Result = (DateTime.UtcNow - start_time).TotalSeconds;
        }

        private void Process_Worker_ProgressChanged( object sender, System.ComponentModel.ProgressChangedEventArgs e )
        {
            if( e.UserState != null && e.UserState is Exception )
            {
                var ex = e.UserState as Exception;
                MessageBox.Show(
                    this,
                    string.Format("Hiba történt:\n{0}", ex.Message),
                    "Hiba",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            this.Process_ProgressBar.Value = e.ProgressPercentage;
        }

        private void Process_Worker_RunWorkerCompleted( object sender, System.ComponentModel.RunWorkerCompletedEventArgs e )
        {
            // Restore Gui
            this.Process_ProgressBar.Visible = false;
            this.SetGuiEnabled(true);
            this.Process_Button.Text = "Feldolgozás";
            this.Process_Button.Enabled = true;

            if( e.Cancelled )
            {
                MessageBox.Show(
                    this,
                    "Felhasználó megszakította.",
                    "Kész",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if( e.Error != null )
            {
                MessageBox.Show(
                    this,
                    string.Format("Hiba történt: {0}\n", e.Error.Message),
                    "Hiba",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(
                    this,
                    string.Format("Eltelt idő: {0:0}s", (double)e.Result),
                    "Kész",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        #endregion
    }
}
