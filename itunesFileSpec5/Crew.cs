using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace itunesFileSpec5
{
    public class Crew
    {
        private List<Role> _roles = new List<Role>();

        public Crew() { }
        public Crew(string billing, string displayName, List<Role> roles)
        {
            Billing = billing;
            DisplayName = displayName;
            Roles = roles;
        }
        [XmlAttribute("billing")]           public string Billing { get; set; }
        [XmlElement("display_name")]        public string DisplayName{ get; set; }
        [XmlElement("roles")]               public List<Role> Roles { get { return _roles; } set { _roles = value; } }
    }
}
