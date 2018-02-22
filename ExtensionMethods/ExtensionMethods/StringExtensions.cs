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
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public static string UpperCaseFirstCharacter(this string instance)
        {
            if (string.IsNullOrEmpty(instance))
            {
                return string.Empty;
            }

            if (instance.Length == 1)
            {
                return char.ToUpper(instance[0]).ToString();
            }

            return char.ToUpper(instance[0]) + instance.Substring(1);
        }
        
        /// <summary>
        /// Lower cases the first character.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>The string.</returns>
        public static string LowerCaseFirstCharacter(this string instance)
        {
            if (string.IsNullOrEmpty(instance))
            {
                return string.Empty;
            }

            if (instance.Length == 1)
            {
                return char.ToLower(instance[0]).ToString();
            }

            return char.ToLower(instance[0]) + instance.Substring(1);
        }

        /// <summary>
        /// To the title case.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public static string ToTitleCase(this string instance)
        {
            return string.IsNullOrEmpty(instance) ? 
                            string.Empty : 
                            CultureInfo.InvariantCulture.TextInfo.ToTitleCase(instance.ToLower());
        }

        /// <summary>
        /// Obfuscates the substring.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="startPoint">The start point.</param>
        /// <param name="length">The length.</param>
        /// <param name="character">The character.</param>
        /// <returns></returns>
        public static string Obfuscate(
            this string instance, 
            int startPoint, 
            int length,
            char character = '*')
        {
            if (string.IsNullOrEmpty(instance))
            {
                return string.Empty;
            }

            if (instance.Length < startPoint)
            {
                return instance;
            }

            if (instance.Length < startPoint + length)
            {
                return instance;
            }

            string start = instance.Substring(0, startPoint);

            string end = instance.Substring(startPoint + length);
            
            return string.Concat(start, new string(character, length), end);
        }
    }
}
