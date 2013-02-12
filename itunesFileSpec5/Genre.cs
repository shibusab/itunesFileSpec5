using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace itunesFileSpec5
{
   public  class Genre
    {
       private List<String> _genreName = new List<string>();

       public Genre() { }
       public Genre(List<string> name)
       {
           GenreName = name;
       }

       [XmlElement("genre")]       public List<string> GenreName { get { return _genreName; } set { _genreName = value; } }
    }
}
