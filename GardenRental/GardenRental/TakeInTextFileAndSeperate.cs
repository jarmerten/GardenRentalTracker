using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenRental
{
    class TakeInTextFileAndSeperate
    {
        List<int> XPointFromFile = new List<int>();
        List<int> YPointFromFile = new List<int>();
        List<int> WidthOfPlotFromFile = new List<int>();
        List<int> HeightOfPlotFromFile = new List<int>();

        public void ReadTxtFile()
        {
            SeperateTxtFilesByLines();
            Console.ReadLine();
        }
        public void SeperateTxtFilesByLines()
        {
            int internalCounter = 0;
            int counter = 0;
            string EachPlotSizeAndOriginPoint;
            System.IO.StreamReader ReadPlotFile =
            new System.IO.StreamReader("C:\\Users\\Jared Merten\\Documents\\GardenRental\\GardenPlotInput.txt");
            while ((EachPlotSizeAndOriginPoint = ReadPlotFile.ReadLine()) != null)
            {
                Console.WriteLine(EachPlotSizeAndOriginPoint);
                SeperateStringIntoSubstrings(internalCounter, EachPlotSizeAndOriginPoint);
                internalCounter = 0;
                counter++;
            }
            ReadPlotFile.Close();
        }
            public void SeperateStringIntoSubstrings(int internalCounter,string EachPlotSizeAndOriginPoint)
        {
            while (internalCounter < 4)
            {
                string myString = "";
                string example = EachPlotSizeAndOriginPoint;
                string SeperateStringsByCommas = example.IndexOf(',') == 0 ? myString : example.Split(',')[internalCounter];
                int TurnStringNumberIntoInt = Int32.Parse(SeperateStringsByCommas);
                AddPointsToList(internalCounter, TurnStringNumberIntoInt);
                Console.WriteLine(SeperateStringsByCommas);
                internalCounter++;
            }
        }
            public void AddPointsToList(int internalCounter, int TurnStringNumberIntoInt)
             {
            switch (internalCounter)
            {
                case 0:
                    {
                        XPointFromFile.Add(TurnStringNumberIntoInt);
                        break;
                    }
                case 1:
                    {
                        YPointFromFile.Add(TurnStringNumberIntoInt);
                        break;
                    }
                case 2:
                    {
                        WidthOfPlotFromFile.Add(TurnStringNumberIntoInt);
                        break;
                    }
                case 3:
                    {
                        HeightOfPlotFromFile.Add(TurnStringNumberIntoInt);
                        break;
                    }
            }
        }
        
    }
}
