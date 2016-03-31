using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenRental
{
    class Program
    {
 
        static void Main(string[] args)
        {
            List<string> readingkey = new List<string>();
            //readingkey.Add("5");
            //readingkey.Add("GardenPlotInput.txt");
            //readingkey.Add("Onebigfence.txt");
            foreach (string arg in args)
            {
                readingkey.Add(arg);
                Console.WriteLine(arg);
            }
            SetUp setup = new SetUp();
            List<string> coolmike = setup.letsgo(readingkey.ElementAt(0), readingkey.ElementAt(1));
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (System.IO.StreamWriter one = new System.IO.StreamWriter(mydocpath + @"\\Visual Studio 2015\\Projects\\GardenRentalTracker\\GardenRental\\GardenRental\\obj\\Debug\\" + readingkey.ElementAt(2)))
            { 
            foreach (string arg in coolmike)
            
                one.WriteLine(arg);
            }
            Console.ReadKey();
        }
    }
}
