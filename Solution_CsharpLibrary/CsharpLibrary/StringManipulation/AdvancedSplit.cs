using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CsharpLibrary.StringManipulation
{
    public class AdvancedSplit
    {
        /// <summary>
        /// Splits a string based on a delimiter but ignores any occurance of the delimiter between quotes
        /// </summary>
        /// <param name="text">The text to split</param>
        /// <param name="delimiter">The character to split by</param>
        /// <returns>Array of strings result</returns>
        public string[] GetSplitString(string text, char delimiter)
        {
            var results = new List<string>();

            using (TextReader rdr = new StringReader(text))
            {
                var state = State.InValue;
                var sb = new StringBuilder();

                int nc;
                while ((nc = rdr.Read()) != -1)
                {
                    var c = (char)nc;

                    switch (state)
                    {
                        case State.InValue:
                            if (c == '"')
                            {
                                state = State.InQuotes;
                            }
                            else if (c == delimiter)
                            {
                                results.Add(sb.ToString());
                                sb.Length = 0;
                            }
                            else
                            {
                                sb.Append(c);
                            }
                            break;

                        case State.InQuotes:
                            if (c == '"')
                            {
                                state = State.InValue;
                            }
                            else
                            {
                                sb.Append(c);
                            }
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                if (sb.Length > 0)
                    results.Add(sb.ToString());
            }

            return results.ToArray();
        }

        private enum State
        {
            InQuotes,
            InValue
        }
    }
}
