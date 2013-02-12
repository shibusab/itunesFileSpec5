using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace itunesFileSpec5.StudentTest
{
    public class Student
    {
        private List<string> _studentName = new List<string>();
        [XmlElement("student")]        public List<String> StudentName { get { return _studentName; } set { _studentName = value; } }
    }
}
