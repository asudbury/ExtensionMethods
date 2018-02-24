namespace Scorchio.ExtensionMethods
{
    using System.IO;
    using System.Xml.Serialization;

    /// <summary>
    /// Object Extensions.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Serializes to Xml.
        /// </summary>
        /// <param name="this">This.</param>
        /// <returns></returns>
        public static string SerializeToXml(this object @this)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(@this.GetType());

            using (StringWriter stringWriter = new StringWriter())
            {
                xmlSerializer.Serialize(stringWriter, @this);

                using (StringReader streamReader = new StringReader(stringWriter.GetStringBuilder().ToString()))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }
    }
}
