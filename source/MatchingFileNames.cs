using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ColorChannelMixer
{
    class MatchingFileNames
    {
        public static IEnumerable<string[]> Find( string dir, string[] patterns )
        {
            if( patterns == null || patterns.Length == 0 )
                throw new ArgumentNullException("patterns");

            if( !Directory.Exists(dir) )
                yield break;

            var candidates = Directory.EnumerateFiles(dir, patterns[0]);

            var concrete_parts_regex = new Regex(
                patterns[0].Replace(".", "\\.").Replace('?', '.').Replace("*", "(.*)"),
                RegexOptions.Compiled);

            var filenames = new List<string>();
            bool all_found;
            foreach( string candidate_full in candidates )
            {
                var candidate = Path.GetFileName(candidate_full);

                all_found = true;
                filenames.Clear();
                filenames.Add(candidate);

                var parts = concrete_parts_regex.Match(candidate);
                for( int i = 1; i < patterns.Length; ++i )
                {
                    var filename = FileNameFromPattern(patterns[i], parts.Groups);
                    if( File.Exists(Path.Combine(dir, filename)) )
                        filenames.Add(filename);
                    else
                        all_found = false;
                }

                if( !all_found )
                    continue;

                // Generate result filename
                filenames.Add(ResultFileNameFromPatterns(patterns, parts.Groups));

                yield return filenames.ToArray();
            }
        }

        private static string FileNameFromPattern( string pattern, GroupCollection parts )
        {
            try
            {
                string filename = pattern;

                // NOTE: On the 0th index is the whole file name.
                for( int i = 1; i < parts.Count; ++i )
                {
                    int ind = filename.IndexOf('*');
                    filename = filename.Remove(ind, 1);
                    filename = filename.Insert(ind, parts[i].Value);
                }
                return filename;
            }
            catch
            {
                return null;
            }
        }

        private static string ResultFileNameFromPatterns( string[] patterns, GroupCollection parts )
        {
            var rslt = new System.Text.StringBuilder();
            var ptr_parts = new List<string[]>();
            for( int i = 0; i < patterns.Length; ++i )
                ptr_parts.Add(patterns[i].Split('*'));

            int ptr_part_num = ptr_parts[0].Length;
            for( int i = 0; i < ptr_part_num; ++i )
            {
                if( i > 0 )
                    rslt.Append(parts[i].Value);

                rslt.Append(string.Join(string.Empty, ptr_parts.Select(ptrs => ptrs[i]).Distinct()));
            }

            return rslt.ToString();
        }
    }
}
