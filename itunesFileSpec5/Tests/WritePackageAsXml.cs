using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace itunesFileSpec5.Tests
{
    [TestFixture]
   public  class WritePackageAsXml
    {
       [Test]
       public void Write()
       {
           string fileName = @"c:\test\mytestxml.xml";
           Package package = new Package();
           package = GetDefaultData();
           CustomSerializer.Write(package, fileName);
           Assert.That(package.Language.Equals("en-US"), "The Language Returned is not en-US");
       }

       private Package GetDefaultData()
       {
           Package package= new Package();
           package.Language = "en-US";
           package.Provider = "Paramount";
           package.Version = "5.0";

           Video video = new Video();
           video.VideoType = "film";
           video.SubType = "feature";
           video.VendorOfferCode = "408CH98720X103";
           video.VendorID = "09736156444";
           video.IsanIdentifier = "0000-0000-03B6-0000-O-0000-0000-2";
           video.UniversalProductCode = "09736156444";
           video.Counry = "US";
           video.OriginalSpokenLocale = "en-US";
           video.Title = "Forrest Gump";
           video.Synopsis = "&quot;Stupid is as stupid does,&quot; says Forrest Gump (played by Tom Hanks in an Oscar-winning performance) as he discusses his relative level of intelligence with a stranger while waiting for a bus. Despite his sub-normal IQ, Gump leads a truly charmed life, with a ringside seat for many of the most memorable events of the second half of the 20th century. Featured alongside Tom Hanks are Sally Field as Forrest's mother; Gary Sinise as his commanding officer in Vietnam; Mykelti Williamson as his ill-fated Army buddy who is familiar with every recipe that involves shrimp; and the special effects artists whose digital magic place Forrest amidst a remarkable array of historical events and people";
           video.ProductionCompany = "Paramount Pictures";
           video.CopyrightCline = "1994 Paramount Pictures";
           video.TheatricalReleaseDate = "2007-05-04";
           
           var genres = new Genre();
           genres.GenreName.Add("Comedy");
           genres.GenreName.Add("Drama");
           video.Genres = genres;


           var ratings = new List<Rating>();
           ratings.Add( new Rating("mpaa","Rated PG-13 for drug content, some sensuality and war violence.", "PG-13"));
           ratings.Add(new Rating("mpaa", "Rated PG-13 for drug content, some sensuality and war violence.", "PG-12")); 
           video.Ratings = ratings;

           var casts = new List<Cast>();
           casts.Add(new Cast( "top","Tom Hanks","Forrest Gump"));
           video.Casts = casts;

           var crews = new List<Crew>();
           var roles= new List<Role>();
           roles.Add( new Role("Director"));
           crews.Add( new Crew("top","Robert Zemeckis",roles));
           video.Crews = crews;

           var chapters = new Chapters();
           chapters.TimecodeFormat = "format>24/999 1000/nonDrop";
           
           var chapterList = new List<Chapter>();
           var artworkFile = new ArtworkFile("chapter01.jpg", new Checksum( "ed93d0f3224a353a4cc8d4175d645130", "md5"), "6591649<");
           chapterList.Add(new Chapter("00:00:00:00", "Forrest's Story Begins", "en-US", artworkFile));
           chapters.Chapter = chapterList;
           video.Chapters = chapters;


           package.Video= video;
           
           return package;
       }
    }
}
