using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace Scuffed_Photogrammetry_Algorithm.HelpMethods
{
    public class RawImageData
    {
        public Image Image { get; set; }
        public IReadOnlyList<Directory> MetaData { get; set; }

    }
}
