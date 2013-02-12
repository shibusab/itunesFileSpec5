using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace itunesFileSpec5
{
    public class CustomSerializer
    {
        public static void Write(Package package, string folderName)
        {
            XmlSerializer serializer = new XmlSerializer(package.GetType());
            using (StreamWriter writer = new StreamWriter(folderName))
            {
                serializer.Serialize(writer.BaseStream, package);
            }
        }

        public static void WriteGeneral(object myClass, string folderName)
        {
            XmlSerializer serializer = new XmlSerializer(myClass.GetType());
            using (StreamWriter writer = new StreamWriter(folderName))
            {
                serializer.Serialize(writer.BaseStream, myClass);
            }
        }

        public static  Package Read(Package package, string folderName)
        {
            XmlSerializer serializer = new XmlSerializer(package.GetType());
            using (StreamReader reader = new StreamReader(folderName))
            {
                object deserialized = serializer.Deserialize(reader.BaseStream);
                package = (Package)deserialized;
            }
            return package;
        }
        
    }
}
