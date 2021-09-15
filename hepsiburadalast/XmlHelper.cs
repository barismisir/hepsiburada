using System.IO;
using System.Xml.Serialization;

namespace hepsiburadalast
{
    public class XmlHelper
    {
        public static T DeserializeXmlToObject<T>(string _xmlData, string _rootAttributeName) where T : class, new()
        {
            XmlSerializer xmlSerializer = new(typeof(T), new XmlRootAttribute(_rootAttributeName));

            using (StringReader streamReader = new(_xmlData))
            {
                return (T)xmlSerializer.Deserialize(streamReader);
            }
        }
    }
}
