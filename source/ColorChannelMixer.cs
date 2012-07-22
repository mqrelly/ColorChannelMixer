using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ColorChannelMixer
{
    public static class ColorChannelMixer
    {
        public static void ProcessImage_Managed( Bitmap[] sources, Color[] filters, ref Bitmap result )
        {
            // Check arguments.
            if( sources == null )
                throw new ArgumentNullException("sources");
            if( sources.Length == 0 )
                throw new ArgumentOutOfRangeException("Sources must not be empty.");
            if( filters == null )
                throw new ArgumentNullException("filters");
            if( filters.Length != sources.Length )
                throw new ArgumentOutOfRangeException("filters", "Filters count must match the count of sources.");

            // Check dimensions of sources.
            int width = sources[0].Width;
            int height = sources[0].Height;
            for( int i = 1; i < sources.Length; ++i )
                if( sources[i].Width != width ||
                    sources[i].Height != height )
                    throw new ArgumentException("Sources must have the same dimensions.");

            // (Re)create the result if needed.
            if( result == null ||
                result.Width != width ||
                result.Height != height )
            {
                if( result != null )
                    result.Dispose();

                result = new Bitmap(width, height);
            }

            // Mix color channels
            for( int y = 0; y < height; ++y )
                for( int x = 0; x < width; ++x )
                {
                    double r = 0;
                    double g = 0;
                    double b = 0;
                    for( int i = 0; i < sources.Length; ++i )
                    {
                        var clr = sources[i].GetPixel(x, y);
                        r += clr.R * filters[i].R / 255d;
                        g += clr.G * filters[i].G / 255d;
                        b += clr.B * filters[i].B / 255d;
                    }

                    result.SetPixel(x, y, Color.FromArgb(
                        (int)Math.Round(r),
                        (int)Math.Round(g),
                        (int)Math.Round(b)));
                }
        }

        public static void ProcessImage_WithMarshal( Bitmap[] sources, Color[] filters, ref Bitmap result )
        {
            // Check arguments.
            if( sources == null )
                throw new ArgumentNullException("sources");
            if( sources.Length == 0 )
                throw new ArgumentOutOfRangeException("Sources must not be empty.");
            if( filters == null )
                throw new ArgumentNullException("filters");
            if( filters.Length != sources.Length )
                throw new ArgumentOutOfRangeException("filters", "Filters count must match the count of sources.");

            // Check dimensions of sources.
            int width = sources[0].Width;
            int height = sources[0].Height;
            for( int i = 1; i < sources.Length; ++i )
                if( sources[i].Width != width ||
                    sources[i].Height != height )
                    throw new ArgumentException("Sources must have the same dimensions.");

            // (Re)create the result if needed.
            if( result == null ||
                result.Width != width ||
                result.Height != height )
            {
                if( result != null )
                    result.Dispose();

                result = new Bitmap(width, height);
            }

            // Lock image pixels in memory for faster access.
            var rect = new Rectangle(0, 0, width, height);
            var result_bits = result.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            var sources_bits = new BitmapData[sources.Length];
            for( int i = 0; i < sources.Length; ++i )
                sources_bits[i] = sources[i].LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            // Mix color channels.
            for( int y = 0; y < height; ++y )
                for( int x = 0; x < width; ++x )
                {
                    double r = 0;
                    double g = 0;
                    double b = 0;
                    for( int i = 0; i < sources.Length; ++i )
                    {
                        r += filters[i].R * Marshal.ReadByte(sources_bits[i].Scan0, y * sources_bits[i].Stride + x * 3 + 2) / 255d;
                        g += filters[i].G * Marshal.ReadByte(sources_bits[i].Scan0, y * sources_bits[i].Stride + x * 3 + 1) / 255d;
                        b += filters[i].B * Marshal.ReadByte(sources_bits[i].Scan0, y * sources_bits[i].Stride + x * 3 + 0) / 255d;
                    }

                    Marshal.WriteByte(result_bits.Scan0, result_bits.Stride * y + x * 3 + 2, (byte)Math.Round(r));
                    Marshal.WriteByte(result_bits.Scan0, result_bits.Stride * y + x * 3 + 1, (byte)Math.Round(g));
                    Marshal.WriteByte(result_bits.Scan0, result_bits.Stride * y + x * 3 + 0, (byte)Math.Round(b));
                }

            // Unlock image pixels.
            result.UnlockBits(result_bits);
            for( int i = 0; i < sources.Length; ++i )
                sources[i].UnlockBits(sources_bits[i]);
        }
    }
}
