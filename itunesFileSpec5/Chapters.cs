using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace itunesFileSpec5
{
    public class Chapters
    {
        private List<Chapter> _chapter = new List<Chapter>();

        [XmlElement("timecode_format")]        public string TimecodeFormat{ get; set; }
        [XmlElement("chapter")]                public List<Chapter> Chapter { get { return _chapter; } set { _chapter = value; } }
    }
}
