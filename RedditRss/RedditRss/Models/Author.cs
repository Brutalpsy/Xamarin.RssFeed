using System.Xml.Serialization;

namespace RedditRss.Models
{
    [XmlRoot(ElementName = "author", Namespace = "http://www.w3.org/2005/Atom")]
    public class Author
    {
        [XmlElement(ElementName = "name", Namespace = "http://www.w3.org/2005/Atom")]
        public string Name { get; set; }
        [XmlElement(ElementName = "uri", Namespace = "http://www.w3.org/2005/Atom")]
        public string Uri { get; set; }
    }
}
