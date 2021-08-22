using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Scuffed_Photogrammetry_Algorithm.HelpMethods;

namespace Scuffed_Photogrammetry_Algorithm.Models
{
    public class ImageInformation
    {

        public ImageInformation(RawImageData rawImageData)
        {

        }




        public bool HasCoordinates => MetaData != null;
        public ImageMetaData MetaData { get; set; }
        public Image Image { get; set; }
    }

}
