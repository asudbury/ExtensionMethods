namespace Scorchio.ExtensionMethods
{
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
    }
}
