using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenRental
{
    class FindFencing
    {
        public void FindAmountOfTotalFencingWithOverlapping(List<int> WidthOfPlotFromFile , List<int> HeightOfPlotFromFile)
        {
            int fencingWidthTotal = 0;
            int fencingHeightTotal = 0;
            int lengthOfWidthList = WidthOfPlotFromFile.Count();
            int counter = 0;
            int totalFencing;
            while(counter<lengthOfWidthList)
            {
                fencingWidthTotal = fencingWidthTotal + WidthOfPlotFromFile.ElementAt(counter);
                fencingHeightTotal = fencingHeightTotal + HeightOfPlotFromFile.ElementAt(counter);
                counter++;
            }
            totalFencing = (fencingHeightTotal + fencingWidthTotal) * 2;
            Console.WriteLine(totalFencing);
        }
        public void TotalAmountOfVertilizerNeeded() //need to finish with totalfencing from above
        {
            int totalFencing=0;
            totalFencing = totalFencing * 2;
        }
    }
}
