using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stigespill_v2
{
    public class Ladder
    {
        // Bools for different type of ladders
        public bool hasLadder;

        public bool isLadderStartUp;
        public bool isLadderEndUp;

        public bool isLadderStartDown;
        public bool isLadderEndDown;


        // A string defining what type of ladder.
        public string typeOfLadder;


        // Start and end points for an up ladder
        public List<int> ladderStartUp;
        public List<int> ladderEndUp;


        // Start and end points for a down ladder
        public List<int> ladderStartDown;
        public List<int> ladderEndDown;


        // I use the constructor for the ladder class,
        // to initiate the model.
        public Ladder()
        {
            var ladders = new List<int>();



            hasLadder = new bool();
            hasLadder = false;
            typeOfLadder = "";

            for (int i = 0; i < 90; i++)
            {
                ladders.Add(i + 1);
            }

            createLadders();
        }


        // This function creates the ladders in the correct position
        public void createLadders()
        {
            ladderStartUp = new List<int>() { 1, 8, 36, 43, 49, 65, 68 };
            ladderEndUp = new List<int>() { 40, 10, 52, 62, 79, 82, 85 };

            ladderStartDown = new List<int>() { 24, 33, 42, 56, 64, 74, 87 };
            ladderEndDown = new List<int>() { 3, 5, 12, 27, 30, 37, 70 };

          
  
        }




        // This function determines, the laddertype, if its up or down, 
        // start or end of an ladder
        // Change the typeOfLadder to the correct ladder type.
        // Checks if there is an ladder in the position pos.
        public void getLadderTypeAtPosition(int pos)
        {

            if (ladderStartUp.Contains(pos))
            {
                isLadderStartUp = true;
                hasLadder = true;
                typeOfLadder = "startUp";

            }

            else if (ladderEndUp.Contains(pos))
            {
                isLadderEndUp = true;
                hasLadder = true;
                typeOfLadder = "endUp";
            }

            else if (ladderStartDown.Contains(pos))
            {
                isLadderStartDown = true;
                hasLadder = true;
                typeOfLadder = "startDown";
            }

            else if (ladderEndDown.Contains(pos))
            {
                isLadderEndDown = true;
                hasLadder = true;
                typeOfLadder = "endDown";
            }

            else
            {
                if (pos != 90)
                {
                    hasLadder = false;
                    typeOfLadder = "";
                }

                else
                {
                    typeOfLadder = "finish";
                }
            }
        }

        public void setLadderColors()
        {
            for (int i = 0; i < ladderStartUp.Count; i++)
            {
                for (int j = 0; j < 90; j++)
                {
                    if (ladderStartUp[i] == j)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }

                    else if (ladderEndUp[i] == j)
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
            }

            for (int i = 0; i < ladderStartDown.Count; i++)
            {
                for (int j = 0; j < 90; j++)
                {
                    if (ladderStartDown[i] == j)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                    }

                    else if (ladderEndDown[i] == j)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }

                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }
            }

        }
    }
}
    

