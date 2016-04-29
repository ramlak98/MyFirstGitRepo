using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "c:\\temp\\myfile.bmp";
            string relativeFile = ".\\woohoo\\temp.bmp";
            string addressName = @"http://www.google.com/blahblah.html";

            Uri uriFile = new Uri(fileName);
            Uri uriRelative = new Uri(uriFile, relativeFile);
            Uri uriAddress = new Uri(addressName);

            Console.WriteLine(uriFile.ToString());
            Console.WriteLine(uriRelative.ToString());
            Console.WriteLine(uriAddress.ToString());
        }
    }
}
