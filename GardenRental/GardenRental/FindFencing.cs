using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenRental
{
    class FindFencing
    {
        public void FindAmountOfTotalFencingWithOverlapping(List<int> WidthOfPlotFromFile, List<int> HeightOfPlotFromFile, List<string> overlapstatement)
        {
            int fencingWidthTotal = 0;
            int fencingHeightTotal = 0;
            int lengthOfWidthList = WidthOfPlotFromFile.Count();
            int counter = 0;
            int totalFencing;
            while (counter < lengthOfWidthList)
            {
                fencingWidthTotal = fencingWidthTotal + WidthOfPlotFromFile.ElementAt(counter);
                fencingHeightTotal = fencingHeightTotal + HeightOfPlotFromFile.ElementAt(counter);
                counter++;
            }
            totalFencing = (fencingHeightTotal + fencingWidthTotal) * 2;
            overlapstatement.Add("The Total Fencing with overlap is " + totalFencing + " feet.");
        }
        public void TotalAmountOfVertilizerNeeded(List<int> EverySquareFootOfGardenPoint, int overlaps, List<string> overlapstatement)
        {
            int totalsquarefeet = EverySquareFootOfGardenPoint.Count;
            totalsquarefeet -= overlaps;
            totalsquarefeet /= 2;
            overlapstatement.Add("You need " + totalsquarefeet + " bottles of fertilizer to fertilize all plots.");
        }
        public void LeastAmountOfFencingNeeded(List<int>WidthOfPlotFromFile, List<int>HeightOfPlotFromFile, List<string> overlapstatement, List<int> XPointFromFile, List<int> YPointFromFile)
        {
            int howmanyplotsstarts = 0;
            int elementcounterforlowestpoint = 9;
            int elementcounterforleftistpoint = 9;
            int elementcounterforfurthestright = 0;
            int elementcounterforhighest = 0;
            int sizeinbigrectangle = 0;

            while(YPointFromFile.Count > howmanyplotsstarts)
            {
                if(YPointFromFile.ElementAt(howmanyplotsstarts) <= elementcounterforlowestpoint)
                {
                    elementcounterforlowestpoint = YPointFromFile.ElementAt(howmanyplotsstarts);
                }
                howmanyplotsstarts++;
            }
            howmanyplotsstarts = 0;
            while (XPointFromFile.Count > howmanyplotsstarts)
            {
                if (XPointFromFile.ElementAt(howmanyplotsstarts) <= elementcounterforleftistpoint)
                {
                    elementcounterforleftistpoint = XPointFromFile.ElementAt(howmanyplotsstarts);
                }
                howmanyplotsstarts++;
            }
            howmanyplotsstarts = 0;
            while (XPointFromFile.Count > howmanyplotsstarts)
            {
                if(XPointFromFile.ElementAt(howmanyplotsstarts) + WidthOfPlotFromFile.ElementAt(howmanyplotsstarts) > elementcounterforfurthestright)
                {
                    elementcounterforfurthestright = XPointFromFile.ElementAt(howmanyplotsstarts) + WidthOfPlotFromFile.ElementAt(howmanyplotsstarts);
                }
                howmanyplotsstarts++;
            }
            howmanyplotsstarts = 0;
            while (YPointFromFile.Count > howmanyplotsstarts)
            {
                if (YPointFromFile.ElementAt(howmanyplotsstarts) + HeightOfPlotFromFile.ElementAt(howmanyplotsstarts) > elementcounterforhighest)
                {
                    elementcounterforhighest = YPointFromFile.ElementAt(howmanyplotsstarts) + HeightOfPlotFromFile.ElementAt(howmanyplotsstarts);
                }
                howmanyplotsstarts++;
            }
            sizeinbigrectangle = ((elementcounterforfurthestright - elementcounterforleftistpoint) + (elementcounterforhighest - elementcounterforlowestpoint)) * 2;
            overlapstatement.Add("If the fence was one big rectangle, you would need " + sizeinbigrectangle + " feet of fence.");
        }
    }
}
