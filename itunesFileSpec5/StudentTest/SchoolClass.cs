using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace itunesFileSpec5.StudentTest
{
    public class SchoolClass
    {
        private Student _students = new Student();

        [XmlElement("class")]        public string ClassName { get; set; }
        [XmlElement("students")]        public Student Students { get { return _students; } set { _students = value; } }
    }
}
