using System;
using System.Collections.Generic;

namespace Stigespill_v2
{
    public class DrawingSequence
    {
       
            public List<int> writeRows()
            {
                var row = new List<int>() { };
                var rows = new List<int>() { };

                for (int i = 9; i > -1; i--)
                {
                    row = createRowDrawingSequence(i, 9);

                    foreach (var elem in row)
                    {
                        rows.Add(elem);
                    }
                }

                return rows;
            }

            public bool isEven(int row)
            {
                // This method check if row is an even or odd row
                // If even row number, the row is reversed
                // Use modulus to the number 2, if even, row % 2 is zero.
                // No remainder.
                if ((row+1) % 2 == 0)
                {
                    return true;
                }
                return false;
            }

            public List<int> createRowDrawingSequence(int rowNum, int rowLength)
            {
                // This method creates on row at a time
                var row = new List<int>() { };

                for (int i = rowLength * rowNum; i < rowLength + (rowLength) * rowNum; i++)
                {
                    row.Add(i + 1);
                }

                if (!isEven(rowNum))
                {
                    row.Reverse();
                }
                return row;
            }

            //public void printBoardToConsole(List<int> drawingSequence)
            //{
            //    // Print board to console in an appropriate format
            //    drawingSequence.ForEach(delegate (int i)
            //    {
            //        Console.Write(i + " ");
            //    });
            //}

            //public List<int> createDrawingSequence()
            //{
            //    // Create every rows of the board game
            //    var drawingSequence = writeRows();
            //    return drawingSequence;
            //}
        }
    }
