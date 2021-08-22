using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Scuffed_Photogrammetry_Algorithm.HelpMethods;

namespace Scuffed_Photogrammetry_Algorithm.Models
{
    public class ImageInformation
    {

        public ImageInformation(ImageMetaData imageMetaData, Image image)
        {
            MetaData = imageMetaData;
            Image = image;
        }

        public ImageMetaData MetaData { get; set; }
        public Image Image { get; set; }
    }

}
