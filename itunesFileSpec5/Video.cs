using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace itunesFileSpec5
{
    public class Video
    {
        [XmlElement("type")]                public string VideoType { get; set; }
        [XmlElement("subtype")]             public string SubType { get; set; }
        [XmlElement("vendor_offer_code")]   public string VendorOfferCode { get; set; }
        [XmlElement("vendor_id")]           public string VendorID { get; set; }
        [XmlElement("isan")]                public string IsanIdentifier { get; set; }
        [XmlElement("upc")]                 public string UniversalProductCode { get; set; }
        [XmlElement("country")]             public string Counry { get; set; }
        [XmlElement("original_spoken_locale")]     public string OriginalSpokenLocale{ get; set; }
        [XmlElement("title")]               public string Title { get; set; }
        [XmlElement("synopsis")]            public string Synopsis{ get; set; }
        [XmlElement("production_company")]  public string ProductionCompany { get; set; }
        [XmlElement("copyright_cline")]     public string CopyrightCline { get; set; }
        [XmlElement("theatrical_release_date")]    public string TheatricalReleaseDate { get; set; }

        [XmlElement("genres")]              public Genre Genres{ get; set; }
        [XmlElement("ratings")]             public List<Rating> Ratings { get; set; }
        [XmlElement("cast")]                public List<Cast> Casts { get; set; }
        [XmlElement("crew")]                public List<Crew> Crews{ get; set; }
        [XmlElement("chapters")]            public Chapters Chapters { get; set; }





    }
}
