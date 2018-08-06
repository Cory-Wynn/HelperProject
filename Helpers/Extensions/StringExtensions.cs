using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Helpers.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Removes all white space in a string
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>The string with white space removed.</returns>
        public static string RemoveWhiteSpace(this string str)
        {
            return Regex.Replace(str, @"\s+", "");
        }
    }
}
