using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace itunesFileSpec5.Tests
{
    [TestFixture]
    class ReadPackageAsXml
    {
        [Test]
        public void Read()
        {
            string fileName = @"c:\test\mytestxml.xml";
            Package package = new Package();
            CustomSerializer.Read(package, fileName);
            Assert.That(package.Language.Equals("en-US"), "The Language Returned is not en-US");
        }
    }
}
