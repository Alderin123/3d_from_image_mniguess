
using System.Collections.Generic;
using System.Drawing;
using MetadataExtractor;
using Scuffed_Photogrammetry_Algorithm.Models;

namespace Scuffed_Photogrammetry_Algorithm.HelpMethods
{
    public static class InputDataHandler
    {

        public static ImageMetaData ReadMetaDataFromFile(string filePath)
        {
            var imageMetaData = new ImageMetaData();
            var rawImageMetaData = ImageMetadataReader.ReadMetadata(filePath);
            var a = 1;
            return imageMetaData;
        }

        public static Image ReadImageDataFromFile(string file)
        {
            Image image = Image.FromFile(file);

            return image;
        }

        public static string[] GetDataFiles(string DataFolderPath)
        {
            string[] filePaths = System.IO.Directory.GetFiles(DataFolderPath);

            return filePaths;
        }
    }
}
