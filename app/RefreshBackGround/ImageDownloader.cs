using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RefreshBackGround
{
    public class ImageDownloader
    {

        private static string myPath = @"E:\BackGroundImage\10000x6000.jpg";

        public static string imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/CONUS/GEOCOLOR/10000x6000.jpg".Trim();

        // A public method that takes an image URL and a local file name as parameters

        public static void CheckDirLocation() { 
           if (Directory.Exists(myPath)) { 
              Directory.CreateDirectory(myPath);
            }
        }
        
        
        
        public static async void DownloadImage(string imageLocation)
        {
            CheckDirLocation();
            using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.GetAsync(imageLocation))
                    {
                        // response.EnsureSuccessStatusCode();
                        using (Stream stream = await response.Content.ReadAsStreamAsync())
                        {
                            using (FileStream fileStream = new FileStream(myPath, FileMode.Create, FileAccess.Write))
                            {
                                stream.CopyTo(fileStream);
                            }
                        }

                    }
                }
        }
    }


}

