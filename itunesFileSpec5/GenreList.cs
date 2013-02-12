using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace itunesFileSpec5
{
    public class GenreList
    {
        private List<Genre> _genre = new List<Genre>();

        public GenreList() { }
        public GenreList(List<Genre> genre)
        {
            _genre = genre;
        }

        [XmlAttribute("genre")]        public List<Genre> Genres { get { return _genre; } set { _genre = value; } }
      
    }
}
