using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Scuffed_Photogrammetry_Algorithm.HelpMethods
{
    public static class FileReader
    {
        public static string[] GetDataFiles(string DataFolderPath)
        {
            string[] files = Directory.GetFiles(DataFolderPath);
            return files;
        }
    }
}
