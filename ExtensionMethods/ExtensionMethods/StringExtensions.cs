namespace Scorchio.ExtensionMethods
{
    using System.Globalization;

    /// <summary>
    /// String Extensions.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Uppercases the first character.
        /// </summary>
        /// <param name="this">This.</param>
        /// <returns></returns>
        public static string UpperCaseFirstCharacter(this string @this)
        {
            if (string.IsNullOrEmpty(@this))
            {
                return string.Empty;
            }

            if (@this.Length == 1)
            {
                return char.ToUpper(@this[0]).ToString();
            }

            return char.ToUpper(@this[0]) + @this.Substring(1);
        }

        /// <summary>
        /// Lower cases the first character.
        /// </summary>
        /// <param name="this">This.</param>
        /// <returns>
        /// The string.
        /// </returns>
        public static string LowerCaseFirstCharacter(this string @this)
        {
            if (string.IsNullOrEmpty(@this))
            {
                return string.Empty;
            }

            if (@this.Length == 1)
            {
                return char.ToLower(@this[0]).ToString();
            }

            return char.ToLower(@this[0]) + @this.Substring(1);
        }

        /// <summary>
        /// To the title case.
        /// </summary>
        /// <param name="this">This.</param>
        /// <returns></returns>
        public static string ToTitleCase(this string @this)
        {
            return string.IsNullOrEmpty(@this) ? 
                            string.Empty : 
                            CultureInfo.InvariantCulture.TextInfo.ToTitleCase(@this.ToLower());
        }

        /// <summary>
        /// Obfuscates the substring.
        /// </summary>
        /// <param name="this">The this.</param>
        /// <param name="startPoint">The start point.</param>
        /// <param name="length">The length.</param>
        /// <param name="character">The character.</param>
        /// <returns></returns>
        public static string Obfuscate(
            this string @this, 
            int startPoint, 
            int length,
            char character = '*')
        {
            if (string.IsNullOrEmpty(@this))
            {
                return string.Empty;
            }

            if (@this.Length < startPoint)
            {
                return @this;
            }

            if (@this.Length < startPoint + length)
            {
                return @this;
            }

            string start = @this.Substring(0, startPoint);

            string end = @this.Substring(startPoint + length);
            
            return string.Concat(start, new string(character, length), end);
        }
    }
}
