using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using itunesFileSpec5.StudentTest;


namespace itunesFileSpec5.Tests
{
    [TestFixture]
    class StudentClassTest
    {
        [Test]
        public void WriteStudent()
        {
            string folderName = @"c:\test\student.xml";
            var schoolClass = new SchoolClass();

            schoolClass.ClassName = "Class 2013";

            var students = new Student();
            students.StudentName.Add("Student1");
            students.StudentName.Add("Student2");
            students.StudentName.Add("Student3");
            students.StudentName.Add("Student4");

            schoolClass.Students = students;

            CustomSerializer.WriteGeneral(schoolClass,folderName);
            
        }
    }
}
