
using System.Collections.Generic;
using System.Drawing;
using MetadataExtractor;


namespace Scuffed_Photogrammetry_Algorithm.HelpMethods
{
    public static class ImageFromFileOpener
    {

        public static IReadOnlyList<Directory> ReadMetaDataFromFile(string file)
        {
            var imageMetaData = ImageMetadataReader.ReadMetadata(file);
            return imageMetaData;
        }

        public static Image ReadImageFromFile(string file)
        {
            Image image = Image.FromFile(file);
            return image;
        }
    }
}
