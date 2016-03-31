using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenRental
{
    class CheckOverLappingGardens
    {

        public int DoGardensOverlap(List<int> WhosNumberedPlot, List<int> EverySquareFootOfGardenPoint, int totalPlots, List<string> overlapstatement, int printoverlaps)
        {
            int totaloverlaps = 0;
            int totalcheckedalready = 0;
            int counter = 0;
            int innercounter = 0;
            int innerinnercounter = 0;
            int totalschecked = 0;
            int why = 0;
            int itsthere = 0;
            int firstoverlap =  0;
            int where = 0;
            totalPlots -= 1;
            WhosNumberedPlot.Add(0);
            List<int> overlaps = new List<int>();
            List<int> overlappedby = new List<int>();

            int innerinnerinnercounter = 0;
            while (counter < totalPlots)
            {
                int gardensize = EverySquareFootOfGardenPoint.Count();
                while (counter == WhosNumberedPlot.ElementAt(totalschecked))
                {
                    totalschecked++;
                }
                gardensize = gardensize - totalschecked;
                int fly = totalschecked;
                    while (counter == WhosNumberedPlot.ElementAt(where))
                    {
                        while (why < totalschecked)
                        {
                            while (innerinnercounter < gardensize)
                            {
                                if (EverySquareFootOfGardenPoint.ElementAt(why) == EverySquareFootOfGardenPoint.ElementAt(fly))
                                {
                                    totaloverlaps++;
                                    if((firstoverlap<1) && (printoverlaps == 1))
                                {
                                    overlaps.Add(WhosNumberedPlot.ElementAt(innercounter));
                                    overlappedby.Add(WhosNumberedPlot.ElementAt(fly));
                                    overlapstatement.Add("Plot " + WhosNumberedPlot.ElementAt(innercounter) + " and Plot " + WhosNumberedPlot.ElementAt(fly) + " overlap");
                                    firstoverlap++;
                                }
                                while (innerinnerinnercounter < overlappedby.Count)
                                {
                                    if (WhosNumberedPlot.ElementAt(why) == overlaps.ElementAt(innerinnerinnercounter) && (WhosNumberedPlot.ElementAt(fly) == overlappedby.ElementAt(innerinnerinnercounter)))
                                    {
                                        itsthere++;
                                    }
                                    innerinnerinnercounter++;
                                }
                                if((itsthere == 0) && (printoverlaps == 1))
                                    {
                                        overlaps.Add(WhosNumberedPlot.ElementAt(innercounter));
                                        overlappedby.Add(WhosNumberedPlot.ElementAt(fly));
                                        overlapstatement.Add("Plot " + WhosNumberedPlot.ElementAt(innercounter) + " and Plot " + WhosNumberedPlot.ElementAt(fly) + " overlap");                      
                                    }

                                itsthere = 0;    
                                }
                                innerinnercounter++;
                            innerinnerinnercounter = 0;
                                 fly++;                       
                            }
                        innercounter++;
                             why++;
                        where++;
                            innerinnercounter = 0;
                               fly = totalschecked;                           
                        }
                        totalcheckedalready++;
                        why = 0;
                        innercounter = 0;
                    }
                     
                    innerinnerinnercounter = 0;
                    counter++;              
                }return totaloverlaps;
        }
    }
}
