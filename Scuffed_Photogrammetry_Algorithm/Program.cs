using System;
using System.IO;
using System.Reflection;
using Scuffed_Photogrammetry_Algorithm.HelpMethods;
using Scuffed_Photogrammetry_Algorithm.Models;


namespace Scuffed_Photogrammetry_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var dataSetDirectory = currentDirectory + "\\TestImages";


            var testImageFiles = RawImageHandler.GetDataFiles(dataSetDirectory);
            var a = 1;



        }
    }
}
