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
            TakeInTextFileAndSeperate ReadData = new TakeInTextFileAndSeperate();
            ReadData.ReadTxtFile();
        }
    }
}
