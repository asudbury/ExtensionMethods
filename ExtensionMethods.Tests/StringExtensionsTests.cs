namespace Scorchio.ExtensionMethods.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class StringExtensionsTests
    {
        /// <summary>
        /// Tests the upper case first character.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        [TestCase("adrian", ExpectedResult = "Adrian")]
        [TestCase("a", ExpectedResult = "A")]
        [TestCase("", ExpectedResult = "")]
        public string TestUpperCaseFirstCharacter(string input)
        {
            return input.UpperCaseFirstCharacter();
        }

        /// <summary>
        /// Tests the lower case first character.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        [TestCase("ADRIAN", ExpectedResult = "aDRIAN")]
        [TestCase("A", ExpectedResult = "a")]
        [TestCase("", ExpectedResult = "")]
        public string TestLowerCaseFirstCharacter(string input)
        {
            return input.LowerCaseFirstCharacter();
        }

        /// <summary>
        /// Tests to title case.
        /// </summary>
        /// <param name="input">The input.</param>
        [TestCase("ADRIAN", ExpectedResult = "Adrian")]
        [TestCase("A", ExpectedResult = "A")]
        [TestCase("", ExpectedResult = "")]
        public string TestToTitleCase(string input)
        {
            return input.ToTitleCase();
        }

        /// <summary>
        /// Tests the obfuscate.
        /// </summary>
        /// <param name="input">The input.</param>
        [TestCase("ADRIAN", ExpectedResult = "AD@@@@")]
        [TestCase("AAAAA", ExpectedResult = "AAAAA")]
        [TestCase("", ExpectedResult = "")]
        public string TestObfuscate(string input)
        {
            return  input.Obfuscate(2,4,'@');
        }
    }
}
