using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace itunesFileSpec5
{
    [XmlRoot("package", Namespace="http://apple.com/itunes/importer")]
   public class Package
    {
        [XmlAttribute("version")]   public string Version {get;set;}
        [XmlElement("language")]    public string Language {get;set;}
        [XmlElement("provider")]    public string Provider {get;set;}
        [XmlElement("video")]       public Video Video { get; set; }


    }
}
