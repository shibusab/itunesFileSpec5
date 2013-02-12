using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace itunesFileSpec5
{
    public class Checksum
    {
        public Checksum() { }
        public Checksum(string checksum, string checksumType) 
        {
            ChecksumValue = checksum;
            ChecksumType = checksumType;
        }
        [XmlText()]                 public string ChecksumValue { get; set; }
        [XmlAttribute("type")]      public string ChecksumType { get; set; }
    }
}
