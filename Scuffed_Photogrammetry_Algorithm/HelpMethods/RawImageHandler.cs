
using System.Collections.Generic;
using System.Drawing;
using MetadataExtractor;
using Scuffed_Photogrammetry_Algorithm.Models;

namespace Scuffed_Photogrammetry_Algorithm.HelpMethods
{
    public static class RawImageHandler
    {

        public static ImageMetaData ReadMetaDataFromFile(string file)
        {
            var imageMetaData = new ImageMetaData();
            var rawImageMetaData = ImageMetadataReader.ReadMetadata(file);



            return imageMetaData;
        }

        public static Image ReadImageFromFile(string file)
        {
            Image image = Image.FromFile(file);
            return image;
        }

        public static string[] GetDataFiles(string DataFolderPath)
        {
            string[] files = System.IO.Directory.GetFiles(DataFolderPath);
            return files;
        }
    }
}
