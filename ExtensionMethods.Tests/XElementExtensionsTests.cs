namespace Scorchio.ExtensionMethods.Tests
{
    using NUnit.Framework;
    using System.Xml.Linq;

    [TestFixture]
    public class XElementExtensionsTests
    {
        /// <summary>
        /// Tests the get attribute value or default.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="attributeName">Name of the attribute.</param>
        /// <param name="expected">The expected.</param>
        /// <param name="defaultValue">The default value.</param>
        [Test, TestCaseSource("AttributeCases")]
        public void TestGetAttributeValueOrDefault(
            XElement element,
            string attributeName,
            string expected,
            string defaultValue)
        {
            string output = element.GetAttributeValueOrDefault(attributeName, defaultValue);

            Assert.AreEqual(output, expected);
        }

        /// <summary>
        /// Tests the get element value or default.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="attributeName">Name of the attribute.</param>
        /// <param name="expected">The expected.</param>
        /// <param name="defaultValue">The default value.</param>
        [Test, TestCaseSource("ElementCases")]
        public void TestGetElementValueOrDefault(
            XElement element,
            string attributeName,
            string expected,
            string defaultValue)
        {
            string output = element.GetElementValueOrDefault(attributeName, defaultValue);

            Assert.AreEqual(output, expected);
        }
        
        /// <summary>
        /// The attribute cases.
        /// </summary>
        private static readonly object[] AttributeCases =
        {
            new object[] { new XElement("Adrian", new XAttribute("Test","Bingo")), "Test", "Bingo", string.Empty},
            new object[] { new XElement("Adrian"), "Test",  string.Empty, string.Empty},
            new object[] { new XElement("Adrian"), "Test",  "Happy", "Happy" }
        };

        /// <summary>
        /// The element cases.
        /// </summary>
        private static readonly object[] ElementCases =
        {
            new object[] { new XElement("Adrian", new XElement("Test","Bingo")), "Test", "Bingo", string.Empty},
            new object[] { new XElement("Adrian"), "Test",  string.Empty, string.Empty},
            new object[] { new XElement("Adrian"), "Test",  "Happy", "Happy" }
        };
    }
}
