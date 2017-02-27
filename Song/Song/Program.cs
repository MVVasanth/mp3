using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Application to start\n");
            //Console.WriteLine("Enter Root Path:\n");
            //var rootPath = Console.ReadLine();
            //for testting
            var rootPath = @"C:\mine\Watch";
            Start(rootPath);
        }

        public static void Start(string rootPath)
        {
            var fileUtil = new mp3Utility();
            //Console.WriteLine("Enter file: {0}", rootPath);

            fileUtil.Find(rootPath);
        }
    }
}
