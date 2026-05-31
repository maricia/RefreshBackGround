using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RefreshBackGroundV3
{
    public class ImageDownloader
    {
        // A public method that takes an image URL and a local file name as parameters
        /*
         *  This method is responsible for downloading an image from the specified URL and saving it to the local file system with the given file name. It uses the HttpClient class to send an HTTP GET request to the image URL and retrieves the response as a stream. The method then creates a FileStream to write the downloaded image data to a file on the local disk. Finally, it returns the path to the saved image file.
         */

        private static readonly string imageDirectory = @"E:\BackGroundImage";
        private static readonly string imagePath = Path.Combine(imageDirectory, "10000x6000.jpg");
        public static readonly string ImageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/CONUS/GEOCOLOR/10000x6000.jpg".Trim();
        
        public static void CheckDirLocation()
        {
            if (!Directory.Exists(imageDirectory))
            {
                Directory.CreateDirectory(imageDirectory);
            }
        }



        public static async Task<string> DownloadImage(string imageUrl)
        {
            CheckDirLocation();

            string fileName = GetFileNameFromUrl(imageUrl);
            string savePath = Path.Combine(imageDirectory, fileName);

            using HttpClient client = new HttpClient();
            using HttpResponseMessage response = await client.GetAsync(imageUrl);

            response.EnsureSuccessStatusCode();

            await using Stream stream = await response.Content.ReadAsStreamAsync();
            await using FileStream fileStream =
                new FileStream(savePath, FileMode.Create, FileAccess.Write);

            await stream.CopyToAsync(fileStream);

            return savePath;
        }

        private static string GetFileNameFromUrl(string imageUrl)
        {
            if (imageUrl.Contains("/Dust/"))
                return "Dust.jpg";

            if (imageUrl.Contains("/CONUS/GEOCOLOR/"))
                return "CONUS_GeoColor.jpg";

            if (imageUrl.Contains("/SECTOR/ga/GEOCOLOR/"))
                return "Gulf_of_America.jpg";

            if (imageUrl.Contains("/SECTOR/sp/GEOCOLOR/"))
                return "GeoColor.jpg";

            return "NOAA_Wallpaper.jpg";
        }


    }


}

