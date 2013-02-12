using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace itunesFileSpec5
{
    public class ArtworkFile
    {
        private Checksum _checksum = new Checksum();

        public ArtworkFile() { }
        public ArtworkFile(string fileName, Checksum  checksum, string size) 
        {
            FileName = fileName;
            Checksum = checksum;
            Size = size;
        }

        [XmlElement("file_name")]       public string FileName { get; set; }
        [XmlElement("checksum")]        public Checksum Checksum { get { return _checksum; } set { _checksum = value; } }
        [XmlElement("size")]            public string Size { get; set; }

    }
}
