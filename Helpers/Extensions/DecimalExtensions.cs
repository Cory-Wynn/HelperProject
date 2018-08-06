using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Extensions
{
    public static class DecimalExtensions
    {
        /// <summary>
        /// Extension method to convert a decimal into a formatted number with commas.
        /// </summary>
        /// <param name="Decimal">The decimal to convert.</param>
        /// <returns>The formatted number as a string. (Input: 10000.00 Output: 10,000.00)</returns>
        public static string ToNumberFormat(decimal? Decimal)
        {
            return Decimal.HasValue ? $"{Decimal:N}" : "";
        }

        /// <summary>
        /// Extension method to convert a decimal into a formatted percentage (2 decimal places).
        /// </summary>
        /// <param name="Decimal">The decimal to convert.</param>
        /// <returns>The formatted number as a string. (Input: 0.8526 Output: 85.26 %)</returns>
        public static string ToPercentageFormat(decimal? Decimal)
        {
            return Decimal.HasValue ? $"{Decimal:P2}" : "";
        }
    }
}
