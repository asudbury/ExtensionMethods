namespace Scorchio.ExtensionMethods
{
    using System.Xml.Linq;

    /// <summary>
    /// XElement Extensions
    /// </summary>
    public static class XElementExtensions
    {
        /// <summary>
        /// Gets the attribute value or default.
        /// </summary>
        /// <param name="this">This.</param>
        /// <param name="attributeName">Name of the attribute.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public static string GetAttributeValueOrDefault(
            this XElement @this,
            string attributeName,
            string defaultValue = "")
        {
            XAttribute attribute = @this.Attribute(attributeName);

            return attribute?.Value ?? defaultValue;
        }

        /// <summary>
        /// Gets the element value or default.
        /// </summary>
        /// <param name="this">This.</param>
        /// <param name="elementName">Name of the element.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns></returns>
        public static string GetElementValueOrDefault(
            this XElement @this,
            string elementName,
            string defaultValue = "")
        {
            XElement element = @this.Element(elementName);

            return element?.Value ?? defaultValue;
        }
    }
}
