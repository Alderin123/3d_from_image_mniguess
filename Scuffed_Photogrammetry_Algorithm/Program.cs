using System;
using System.Collections.Generic;
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
            var imageFilePaths = RawDataHandler.GetDataFiles(dataSetDirectory);


            var imageInformationList = new List<ImageInformation>();
            for(int i= 0; i <= imageFilePaths.Length; i++)
            {
                var imageMetaData = RawDataHandler.ReadMetaDataFromFile(imageFilePaths[i]);
                var imageData = RawDataHandler.ReadImageDataFromFile(imageFilePaths[i]);
                imageInformationList.Add(new ImageInformation(imageMetaData, imageData));

            }
        }
    }
}
