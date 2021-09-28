using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stigespill_v2
{


    public class PrintClass
    {
       public PrintClass(Model model, int pos)
        {   
            printGameMatrix(model, pos);
            printStatus(model, pos);
        }


        public void printGameMatrix(Model model, int pos)
        {

            var listOfRows = model.listOfRows;


            for (int i = listOfRows.Count - 1; i > -1; i--)
            {
                var row = listOfRows[i];
                for (int j = listOfRows[i].Count - 1; j > -1; j--)
                {



                    if (i < 1)
                    {
                        Console.Write($"0{row[j]}" + " ");

                    }

                    else
                    {
                        Console.Write(row[j] + " ");
                    }

                }
                Console.WriteLine();

            }
        }


        public void printStatus(Model model, int pos)
        {
            var ladderList = new Ladder();
            //ladders.changePosition(pos);
            ladderList.getLadderTypeAtPosition(pos);
            

            Console.WriteLine($"\nYour are in position {pos}");
            Console.WriteLine($"Has a ladder: {ladderList.hasLadder}");

            if (ladderList.hasLadder)
            {
                Console.WriteLine($"Ladder type: {ladderList.typeOfLadder}");
            }
        }

    }
}
