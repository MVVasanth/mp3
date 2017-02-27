using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    public class mp3Utility
    {
        public string RootPath { get; set; }

        public void Find(string filePath)
        {
            //loop through all folders.
            var folderNames = Directory.GetFiles(filePath);
            //var currentDirectory = 
        }

        public void Move(string sourcePath, string destPath)
        {

        }

        public void Delete(string filePath)
        {

        }
    }
}
