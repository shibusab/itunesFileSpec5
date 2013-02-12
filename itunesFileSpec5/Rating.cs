using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace itunesFileSpec5
{
    public class Rating
    {
        public Rating() { }
        public Rating(string system, string reason, string text)
        {
            System = system;
            Reason = reason;
            Text = text;
        }
        [XmlAttribute("system")]    public string System { get; set; }
        [XmlAttribute("reason")]    public string Reason { get; set; }
        [XmlText()]                 public string Text { get; set; }
    }
}
