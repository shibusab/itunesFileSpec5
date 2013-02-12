using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace itunesFileSpec5
{
   public  class Chapter
    {
       private ArtworkFile _artworkFile = new ArtworkFile();

       public Chapter() { }
       public Chapter(string startTime, string title, string locale, ArtworkFile artworkFile) 
       {
           StartTime = startTime;
           Title = title;
           Locale = locale;
           _artworkFile = artworkFile;
       }
       [XmlElement("start_time")]       public string StartTime { get; set; }
       [XmlElement("title")]            public string Title{ get; set; }
       [XmlElement("locale")]           public string Locale { get; set; }
       [XmlElement("artwork_file")]
       public ArtworkFile ArtworkFile { get { return _artworkFile; } set { _artworkFile = value; } }

    }
}
