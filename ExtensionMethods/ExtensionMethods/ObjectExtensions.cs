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
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public static string SerializeToXml(this object instance)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(instance.GetType());

            using (StringWriter stringWriter = new StringWriter())
            {
                xmlSerializer.Serialize(stringWriter, instance);

                using (StringReader streamReader = new StringReader(stringWriter.GetStringBuilder().ToString()))
                {
                    return streamReader.ReadToEnd();
                }
            }
        }
    }
}
