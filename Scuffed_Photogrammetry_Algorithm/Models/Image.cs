using System;
using System.Collections.Generic;
using System.Text;

namespace Scuffed_Photogrammetry_Algorithm.Models
{
    public class Image
    {


        public bool HasCoordinates => MetaData != null;

        public ImageMetaData MetaData { get; set; }
    }

}
