using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace itunesFileSpec5
{
   public  class Role
    {
       public Role() { }
       public Role(string roleName)
       {
           RoleName = roleName;
       }
       [XmlElement("role")]       public string RoleName { get; set; }
    }
}
