using System.Xml;
using System.Xml.Serialization;

public class Word
{
    [XmlAttribute("name")]
    public string name;

    public string In;
    public string en;
}
