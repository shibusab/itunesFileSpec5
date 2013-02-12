using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace itunesFileSpec5
{
    public class Cast
    {
        public Cast() { }
        public Cast(string billing, string displayName, string characterName)
        {
            Billing = billing;
            DisplayName = displayName;
            CharacterName = characterName;
        }
        [XmlAttribute("billing")]          public string Billing { get; set; }
        [XmlElement("display_name")]       public string DisplayName { get; set; }
        [XmlElement("character_name")]     public string CharacterName { get; set; }

    }
}
