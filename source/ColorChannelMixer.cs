using System;
using System.Drawing;

namespace ColorChannelMixer
{
    public static class ColorChannelMixer
    {
        public static void ProcessImage( Bitmap[] sources, Color[] filters, ref Bitmap result )
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

            // Create result
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
    }
}
