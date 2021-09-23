using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StigespilletJS
{
    public class Model
    {
        // Could define them all as private, since they are not used
        // Outside of the Model class.

        public int[] ladders;
        public int[] drawingSequence;

        public bool isLadderStartUp;
        public bool isLadderEndUp;

        public bool isLadderStartDown;
        public bool isLadderEndDown;

        public int[] ladderStartUp;
        public int[] ladderEndUp;
        public int[] ladderStartDown;
        public int[] ladderEndDown;


        public Model() // Model constructor, model initializer, so we dont need initModel.
        {
            ladders = ladders = new int[90];
            drawingSequence = new int[] { };

            ladderStartUp = new int[] { 1, 36, 43, 49, 65, 68 };
            ladderEndUp = new int[] { 40, 10, 52, 62, 79, 82, 85 };

            ladderStartDown = new int[] { 24, 33, 42, 56, 64, 74, 87 };
            ladderEndDown = new int[] { 3, 5, 12, 27, 30, 37, 70 };

            this.initModel(); // Could place the content of initModel inside the constructor for the Model 
                              // class. Instead of calling initModel. Using this, to refer to the create object of the class model.
                              // The constructor initialize the model. 
            
        }


        public void initModel() 
        {
            drawingSequence = new int[90];

            for (int i = 0; i < 90; i++)
            {
                drawingSequence[i] = i + 1;
            }

            // Ladder positions, both up and down ladders.
            ladders[1] = 40;
            ladders[33] = 3;
            ladders[8] = 10;
            ladders[24] = 5;
            ladders[8] = 10;
            ladders[74] = 12;
            ladders[64] = 27;
            ladders[42] = 30;
            ladders[36] = 52;
            ladders[56] = 37;
            ladders[43] = 62;
            ladders[49] = 79;
            ladders[65] = 82;
            ladders[68] = 85;
            ladders[87] = 75;


        }


        public string getPositionType(int pos)
        {     
            // This methods gets the type of position on the board.
        
            string typeString;

            if (isStartUp(pos))
            {
                // Checks if start up ladder is true
                // If true return ladderStartUp
                typeString = "ladderStartUp";
            }

            else if (isStartDown(pos))
            {
                // Checks if start up ladder is true
                // If true return ladderStartDown
                typeString = "ladderStartDown";
            }

            else if (isEndUp(pos))
            {
                // Checks if start up ladder is true
                // If true return ladderEndUp
                typeString = "ladderEndUp";
            }

            else if (isEndDown(pos))
            {
                // Checks if start up ladder is true
                // If true return ladderEndDown
                typeString = "ladderEndDown";
            }

            else
            {
                // If position is a regular one
                // Return empty string if true
                typeString = "";
            }

            return typeString;
        }

    

        public bool isStartUp(int pos) {
            // Checks if position is a start of an up ladder
            // Return true if true

            var len = ladderStartUp.Length;
            bool isLadderStartUp = false;
            for (int i = 0; i < len; i++)
            {
                if (pos == ladderStartUp[i])
                {
                    isLadderStartUp = true;
                }
            }

            return isLadderStartUp;
        }

        public bool isEndUp(int pos)
        {   // Checks if position is an end of an up ladder
            // Return true if true

            var len = ladderEndUp.Length;

            bool isladderEndUp = false;
            for (int i = 0; i < len; i++) {
                    if (pos == ladderEndUp[i])
                {
                    isladderEndUp = true;
                }
            }
            return isladderEndUp;
        }
       


public bool isStartDown(int pos)
        {  
            // Checks if position is a start of a down ladder
            // Return true if true

            var len = ladderStartDown.Length;
            bool isLadderStartDown = false;
            for (int i = 0; i < len; i++)
            {
                if (pos == ladderStartDown[i])
                {
                    isLadderStartDown = true;
                }
            }

            return isLadderStartDown;
        }



        public bool isEndDown(int pos)
        {
            // Checks if position is a end of a down ladder
            // Return true if true
            var len = ladderEndDown.Length;
            bool isLadderEndDown = false;
            for (int i = 0; i < len; i++)
            {
                if (pos == ladderEndDown[i])
                {
                    isLadderEndDown = true;
                }
            }

            return isLadderEndDown;
        }
    }
    }

