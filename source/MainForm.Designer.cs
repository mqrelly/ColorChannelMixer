namespace ColorChannelMixer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Source3_Panel = new System.Windows.Forms.Panel();
            this.Source3_ColorChannel_ComboBox = new System.Windows.Forms.ComboBox();
            this.Source3_FileNamePattern_TextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Source2_Panel = new System.Windows.Forms.Panel();
            this.Source2_ColorChannel_ComboBox = new System.Windows.Forms.ComboBox();
            this.Source2_FileNamePattern_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Process_Button = new System.Windows.Forms.Button();
            this.SourceNumer_Panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceNumber_TrackBar = new System.Windows.Forms.TrackBar();
            this.SourceNumber_Label = new System.Windows.Forms.Label();
            this.Source1_Panel = new System.Windows.Forms.Panel();
            this.Source1_ColorChannel_ComboBox = new System.Windows.Forms.ComboBox();
            this.Source1_FileNamePattern_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WorkingDirectory_Panel = new System.Windows.Forms.Panel();
            this.WorkingDirectory_Browser_Button = new System.Windows.Forms.Button();
            this.WorkingDirectory_TextBox = new System.Windows.Forms.TextBox();
            this.WorkingDirectory_Label = new System.Windows.Forms.Label();
            this.Process_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.WorkingDirectory_BrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Process_Worker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.Source3_Panel.SuspendLayout();
            this.Source2_Panel.SuspendLayout();
            this.SourceNumer_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceNumber_TrackBar)).BeginInit();
            this.Source1_Panel.SuspendLayout();
            this.WorkingDirectory_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.Source3_Panel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Source2_Panel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Process_Button, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.SourceNumer_Panel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Source1_Panel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.WorkingDirectory_Panel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Process_ProgressBar, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 407);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Source3_Panel
            // 
            this.Source3_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Source3_Panel.Controls.Add(this.Source3_ColorChannel_ComboBox);
            this.Source3_Panel.Controls.Add(this.Source3_FileNamePattern_TextBox);
            this.Source3_Panel.Controls.Add(this.label11);
            this.Source3_Panel.Controls.Add(this.label12);
            this.Source3_Panel.Controls.Add(this.label13);
            this.Source3_Panel.Location = new System.Drawing.Point(0, 181);
            this.Source3_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Source3_Panel.Name = "Source3_Panel";
            this.Source3_Panel.Size = new System.Drawing.Size(360, 62);
            this.Source3_Panel.TabIndex = 3;
            this.Source3_Panel.Visible = false;
            // 
            // Source3_ColorChannel_ComboBox
            // 
            this.Source3_ColorChannel_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Source3_ColorChannel_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Source3_ColorChannel_ComboBox.FormattingEnabled = true;
            this.Source3_ColorChannel_ComboBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.Source3_ColorChannel_ComboBox.Location = new System.Drawing.Point(261, 5);
            this.Source3_ColorChannel_ComboBox.Name = "Source3_ColorChannel_ComboBox";
            this.Source3_ColorChannel_ComboBox.Size = new System.Drawing.Size(87, 22);
            this.Source3_ColorChannel_ComboBox.TabIndex = 2;
            this.Source3_ColorChannel_ComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ColorChannel_ComboBox_DrawItem);
            // 
            // Source3_FileNamePattern_TextBox
            // 
            this.Source3_FileNamePattern_TextBox.Location = new System.Drawing.Point(261, 33);
            this.Source3_FileNamePattern_TextBox.Name = "Source3_FileNamePattern_TextBox";
            this.Source3_FileNamePattern_TextBox.Size = new System.Drawing.Size(87, 21);
            this.Source3_FileNamePattern_TextBox.TabIndex = 4;
            this.Source3_FileNamePattern_TextBox.Text = "*_*_*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(137, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Fájlnév minta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(137, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Színcsatorna";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Forrás 3";
            // 
            // Source2_Panel
            // 
            this.Source2_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Source2_Panel.Controls.Add(this.Source2_ColorChannel_ComboBox);
            this.Source2_Panel.Controls.Add(this.Source2_FileNamePattern_TextBox);
            this.Source2_Panel.Controls.Add(this.label8);
            this.Source2_Panel.Controls.Add(this.label9);
            this.Source2_Panel.Controls.Add(this.label10);
            this.Source2_Panel.Location = new System.Drawing.Point(0, 119);
            this.Source2_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Source2_Panel.Name = "Source2_Panel";
            this.Source2_Panel.Size = new System.Drawing.Size(360, 62);
            this.Source2_Panel.TabIndex = 2;
            // 
            // Source2_ColorChannel_ComboBox
            // 
            this.Source2_ColorChannel_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Source2_ColorChannel_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Source2_ColorChannel_ComboBox.FormattingEnabled = true;
            this.Source2_ColorChannel_ComboBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.Source2_ColorChannel_ComboBox.Location = new System.Drawing.Point(261, 5);
            this.Source2_ColorChannel_ComboBox.Name = "Source2_ColorChannel_ComboBox";
            this.Source2_ColorChannel_ComboBox.Size = new System.Drawing.Size(87, 22);
            this.Source2_ColorChannel_ComboBox.TabIndex = 2;
            this.Source2_ColorChannel_ComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ColorChannel_ComboBox_DrawItem);
            // 
            // Source2_FileNamePattern_TextBox
            // 
            this.Source2_FileNamePattern_TextBox.Location = new System.Drawing.Point(261, 33);
            this.Source2_FileNamePattern_TextBox.Name = "Source2_FileNamePattern_TextBox";
            this.Source2_FileNamePattern_TextBox.Size = new System.Drawing.Size(87, 21);
            this.Source2_FileNamePattern_TextBox.TabIndex = 4;
            this.Source2_FileNamePattern_TextBox.Text = "*_cFOS_*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fájlnév minta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Színcsatorna";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Forrás 2";
            // 
            // Process_Button
            // 
            this.Process_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Process_Button.AutoSize = true;
            this.Process_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Process_Button.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Process_Button.Location = new System.Drawing.Point(263, 369);
            this.Process_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Process_Button.Name = "Process_Button";
            this.Process_Button.Padding = new System.Windows.Forms.Padding(3);
            this.Process_Button.Size = new System.Drawing.Size(91, 32);
            this.Process_Button.TabIndex = 6;
            this.Process_Button.Text = "Feldolgozás";
            this.Process_Button.UseVisualStyleBackColor = true;
            this.Process_Button.Click += new System.EventHandler(this.Process_Button_Click);
            // 
            // SourceNumer_Panel
            // 
            this.SourceNumer_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceNumer_Panel.Controls.Add(this.label4);
            this.SourceNumer_Panel.Controls.Add(this.label3);
            this.SourceNumer_Panel.Controls.Add(this.label2);
            this.SourceNumer_Panel.Controls.Add(this.SourceNumber_TrackBar);
            this.SourceNumer_Panel.Controls.Add(this.SourceNumber_Label);
            this.SourceNumer_Panel.Location = new System.Drawing.Point(0, 0);
            this.SourceNumer_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.SourceNumer_Panel.Name = "SourceNumer_Panel";
            this.SourceNumer_Panel.Size = new System.Drawing.Size(360, 57);
            this.SourceNumer_Panel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1";
            // 
            // SourceNumber_TrackBar
            // 
            this.SourceNumber_TrackBar.LargeChange = 1;
            this.SourceNumber_TrackBar.Location = new System.Drawing.Point(200, 6);
            this.SourceNumber_TrackBar.Maximum = 3;
            this.SourceNumber_TrackBar.Minimum = 1;
            this.SourceNumber_TrackBar.Name = "SourceNumber_TrackBar";
            this.SourceNumber_TrackBar.Size = new System.Drawing.Size(144, 45);
            this.SourceNumber_TrackBar.TabIndex = 1;
            this.SourceNumber_TrackBar.Value = 2;
            this.SourceNumber_TrackBar.ValueChanged += new System.EventHandler(this.SourceNumber_TrackBar_ValueChanged);
            // 
            // SourceNumber_Label
            // 
            this.SourceNumber_Label.AutoSize = true;
            this.SourceNumber_Label.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SourceNumber_Label.Location = new System.Drawing.Point(12, 9);
            this.SourceNumber_Label.Name = "SourceNumber_Label";
            this.SourceNumber_Label.Size = new System.Drawing.Size(165, 13);
            this.SourceNumber_Label.TabIndex = 0;
            this.SourceNumber_Label.Text = "Kombinálandó képek száma";
            // 
            // Source1_Panel
            // 
            this.Source1_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Source1_Panel.Controls.Add(this.Source1_ColorChannel_ComboBox);
            this.Source1_Panel.Controls.Add(this.Source1_FileNamePattern_TextBox);
            this.Source1_Panel.Controls.Add(this.label7);
            this.Source1_Panel.Controls.Add(this.label6);
            this.Source1_Panel.Controls.Add(this.label5);
            this.Source1_Panel.Location = new System.Drawing.Point(0, 57);
            this.Source1_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Source1_Panel.Name = "Source1_Panel";
            this.Source1_Panel.Size = new System.Drawing.Size(360, 62);
            this.Source1_Panel.TabIndex = 1;
            // 
            // Source1_ColorChannel_ComboBox
            // 
            this.Source1_ColorChannel_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Source1_ColorChannel_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Source1_ColorChannel_ComboBox.FormattingEnabled = true;
            this.Source1_ColorChannel_ComboBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.Source1_ColorChannel_ComboBox.Location = new System.Drawing.Point(261, 7);
            this.Source1_ColorChannel_ComboBox.Name = "Source1_ColorChannel_ComboBox";
            this.Source1_ColorChannel_ComboBox.Size = new System.Drawing.Size(87, 22);
            this.Source1_ColorChannel_ComboBox.TabIndex = 2;
            this.Source1_ColorChannel_ComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ColorChannel_ComboBox_DrawItem);
            // 
            // Source1_FileNamePattern_TextBox
            // 
            this.Source1_FileNamePattern_TextBox.Location = new System.Drawing.Point(261, 33);
            this.Source1_FileNamePattern_TextBox.Name = "Source1_FileNamePattern_TextBox";
            this.Source1_FileNamePattern_TextBox.Size = new System.Drawing.Size(87, 21);
            this.Source1_FileNamePattern_TextBox.TabIndex = 4;
            this.Source1_FileNamePattern_TextBox.Text = "*_CTB_*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fájlnév minta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Színcsatorna";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Forrás 1";
            // 
            // WorkingDirectory_Panel
            // 
            this.WorkingDirectory_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorkingDirectory_Panel.Controls.Add(this.WorkingDirectory_Browser_Button);
            this.WorkingDirectory_Panel.Controls.Add(this.WorkingDirectory_TextBox);
            this.WorkingDirectory_Panel.Controls.Add(this.WorkingDirectory_Label);
            this.WorkingDirectory_Panel.Location = new System.Drawing.Point(0, 243);
            this.WorkingDirectory_Panel.Margin = new System.Windows.Forms.Padding(0);
            this.WorkingDirectory_Panel.Name = "WorkingDirectory_Panel";
            this.WorkingDirectory_Panel.Size = new System.Drawing.Size(360, 56);
            this.WorkingDirectory_Panel.TabIndex = 4;
            // 
            // WorkingDirectory_Browser_Button
            // 
            this.WorkingDirectory_Browser_Button.AutoSize = true;
            this.WorkingDirectory_Browser_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WorkingDirectory_Browser_Button.Image = ((System.Drawing.Image)(resources.GetObject("WorkingDirectory_Browser_Button.Image")));
            this.WorkingDirectory_Browser_Button.Location = new System.Drawing.Point(320, 21);
            this.WorkingDirectory_Browser_Button.Name = "WorkingDirectory_Browser_Button";
            this.WorkingDirectory_Browser_Button.Padding = new System.Windows.Forms.Padding(3);
            this.WorkingDirectory_Browser_Button.Size = new System.Drawing.Size(28, 28);
            this.WorkingDirectory_Browser_Button.TabIndex = 2;
            this.WorkingDirectory_Browser_Button.UseVisualStyleBackColor = true;
            this.WorkingDirectory_Browser_Button.Click += new System.EventHandler(this.WorkingDirectory_Browser_Button_Click);
            // 
            // WorkingDirectory_TextBox
            // 
            this.WorkingDirectory_TextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WorkingDirectory_TextBox.Location = new System.Drawing.Point(28, 26);
            this.WorkingDirectory_TextBox.Name = "WorkingDirectory_TextBox";
            this.WorkingDirectory_TextBox.ReadOnly = true;
            this.WorkingDirectory_TextBox.Size = new System.Drawing.Size(286, 21);
            this.WorkingDirectory_TextBox.TabIndex = 1;
            this.WorkingDirectory_TextBox.Text = "C:\\";
            // 
            // WorkingDirectory_Label
            // 
            this.WorkingDirectory_Label.AutoSize = true;
            this.WorkingDirectory_Label.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WorkingDirectory_Label.Location = new System.Drawing.Point(12, 10);
            this.WorkingDirectory_Label.Name = "WorkingDirectory_Label";
            this.WorkingDirectory_Label.Size = new System.Drawing.Size(97, 13);
            this.WorkingDirectory_Label.TabIndex = 0;
            this.WorkingDirectory_Label.Text = "Munkakönyvtár";
            // 
            // Process_ProgressBar
            // 
            this.Process_ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Process_ProgressBar.Location = new System.Drawing.Point(16, 302);
            this.Process_ProgressBar.Margin = new System.Windows.Forms.Padding(16, 3, 12, 3);
            this.Process_ProgressBar.Name = "Process_ProgressBar";
            this.Process_ProgressBar.Size = new System.Drawing.Size(332, 12);
            this.Process_ProgressBar.TabIndex = 5;
            this.Process_ProgressBar.Visible = false;
            // 
            // WorkingDirectory_BrowserDialog
            // 
            this.WorkingDirectory_BrowserDialog.Description = "Adja meg, melyik könyvtárban találhatóak a feldolgozandó képek!";
            this.WorkingDirectory_BrowserDialog.ShowNewFolderButton = false;
            // 
            // Process_Worker
            // 
            this.Process_Worker.WorkerReportsProgress = true;
            this.Process_Worker.WorkerSupportsCancellation = true;
            this.Process_Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Process_Worker_DoWork);
            this.Process_Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Process_Worker_ProgressChanged);
            this.Process_Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Process_Worker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(360, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Színcsatorna keverő";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Source3_Panel.ResumeLayout(false);
            this.Source3_Panel.PerformLayout();
            this.Source2_Panel.ResumeLayout(false);
            this.Source2_Panel.PerformLayout();
            this.SourceNumer_Panel.ResumeLayout(false);
            this.SourceNumer_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceNumber_TrackBar)).EndInit();
            this.Source1_Panel.ResumeLayout(false);
            this.Source1_Panel.PerformLayout();
            this.WorkingDirectory_Panel.ResumeLayout(false);
            this.WorkingDirectory_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Process_Button;
        private System.Windows.Forms.Panel SourceNumer_Panel;
        private System.Windows.Forms.Panel Source1_Panel;
        private System.Windows.Forms.TrackBar SourceNumber_TrackBar;
        private System.Windows.Forms.Label SourceNumber_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Source1_FileNamePattern_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Source3_Panel;
        private System.Windows.Forms.TextBox Source3_FileNamePattern_TextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel Source2_Panel;
        private System.Windows.Forms.TextBox Source2_FileNamePattern_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel WorkingDirectory_Panel;
        private System.Windows.Forms.Label WorkingDirectory_Label;
        private System.Windows.Forms.Button WorkingDirectory_Browser_Button;
        private System.Windows.Forms.TextBox WorkingDirectory_TextBox;
        private System.Windows.Forms.ComboBox Source1_ColorChannel_ComboBox;
        private System.Windows.Forms.ComboBox Source3_ColorChannel_ComboBox;
        private System.Windows.Forms.ComboBox Source2_ColorChannel_ComboBox;
        private System.Windows.Forms.FolderBrowserDialog WorkingDirectory_BrowserDialog;
        private System.Windows.Forms.ProgressBar Process_ProgressBar;
        private System.ComponentModel.BackgroundWorker Process_Worker;
    }
}

