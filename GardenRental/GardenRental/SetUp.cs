using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenRental
{
    class SetUp
    {
        public TakeInTextFileAndSeperate ReadData = new TakeInTextFileAndSeperate();
        public LayoutOfGarden layout = new LayoutOfGarden();
        public FindFencing find = new FindFencing();
        public CheckOverLappingGardens checkeroverlap = new CheckOverLappingGardens();
        public List<string> overlapstatement = new List<string>();
        public List<int> WhosNumberedPlot = new List<int>();
        public List<int> EverySquareFootOfGardenPoint = new List<int>();
        public  SetUp()
        {}
            public List<string> letsgo (string firstelement, string secondelement)
        {
            int totaloverlaps = 0;
            switch (firstelement)
            {
                case "1":
                    {
                        ReadData.SeperateTxtFilesByLines(secondelement);
                        layout.CreateAllPoints(ReadData.XPointFromFile, ReadData.YPointFromFile, ReadData.WidthOfPlotFromFile, ReadData.HeightOfPlotFromFile, WhosNumberedPlot, EverySquareFootOfGardenPoint);
                        totaloverlaps = checkeroverlap.DoGardensOverlap(WhosNumberedPlot, EverySquareFootOfGardenPoint, layout.counter, overlapstatement,1);
                        return overlapstatement;
                    }
                case "2":
                    {
                        ReadData.SeperateTxtFilesByLines(secondelement);
                        find.FindAmountOfTotalFencingWithOverlapping(ReadData.WidthOfPlotFromFile, ReadData.HeightOfPlotFromFile, overlapstatement);
                        return overlapstatement;
                    }
                case "3":
                    {
                        ReadData.SeperateTxtFilesByLines(secondelement);
                        layout.CreateAllPoints(ReadData.XPointFromFile, ReadData.YPointFromFile, ReadData.WidthOfPlotFromFile, ReadData.HeightOfPlotFromFile, WhosNumberedPlot, EverySquareFootOfGardenPoint);
                        find.LeastAmountOfFencingNeeded(ReadData.WidthOfPlotFromFile, ReadData.HeightOfPlotFromFile, overlapstatement,ReadData.XPointFromFile, ReadData.YPointFromFile);
                        return overlapstatement;
                    }
                case "4":
                    {

                        layout.CreateAllPoints(ReadData.XPointFromFile, ReadData.YPointFromFile, ReadData.WidthOfPlotFromFile, ReadData.HeightOfPlotFromFile, WhosNumberedPlot, EverySquareFootOfGardenPoint);
                        totaloverlaps = checkeroverlap.DoGardensOverlap(WhosNumberedPlot, EverySquareFootOfGardenPoint, layout.counter, overlapstatement, 0);
                        find.TotalAmountOfVertilizerNeeded(EverySquareFootOfGardenPoint, totaloverlaps, overlapstatement);
                        return overlapstatement;
                    }
                case "5":
                    {
                        ReadData.SeperateTxtFilesByLines(secondelement);
                        int plotstotal = 0;
                        while (ReadData.XPointFromFile.Count > plotstotal)
                        {
                            overlapstatement.Add(ReadData.XPointFromFile.ElementAt(plotstotal).ToString() + "," + ReadData.YPointFromFile.ElementAt(plotstotal).ToString() + "," + ReadData.HeightOfPlotFromFile.ElementAt(plotstotal).ToString() + "," + ReadData.WidthOfPlotFromFile.ElementAt(plotstotal).ToString());
                            plotstotal++;                       
                        }
                        return overlapstatement;
                    }
            }
            return overlapstatement;
        }
    }
}
