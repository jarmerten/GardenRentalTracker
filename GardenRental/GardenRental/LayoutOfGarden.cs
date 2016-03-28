using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenRental
{
    class LayoutOfGarden
    {
        List<int> WhosNumberedPlot = new List<int>();
        List<int> EverySquareFootOfGardenPoint = new List<int>();
        public void CreateAllPoints(List<int> XPointFromFile, List<int> YPointFromFile, List<int> WidthOfPlotFromFile, List<int> HeightOfPlotFromFile)
        {
            int innerinnercounter = 0;
            int innercounter = 0;
            int counter = 0;
            int point = 0;
            int widthcounter = 0;
            int heightcounter = 0;
            while(counter < XPointFromFile.Count)
            {
                widthcounter = WidthOfPlotFromFile.ElementAt(counter);
                heightcounter = HeightOfPlotFromFile.ElementAt(counter);
                point = (XPointFromFile.ElementAt(counter)) * 10 + YPointFromFile.ElementAt(counter);
                while(innercounter < widthcounter)
                {
                    EverySquareFootOfGardenPoint.Add(point);
                    WhosNumberedPlot.Add(counter);
                    while(innerinnercounter < heightcounter)
                    {
                        point++;
                        EverySquareFootOfGardenPoint.Add(point);
                        WhosNumberedPlot.Add(counter);
                        innerinnercounter++;
                    }
                    point = point + 10;
                    innerinnercounter = 0;
                    innercounter++;
                }
                    innercounter = 0;
                    counter++;
            }
        }
    }
}
