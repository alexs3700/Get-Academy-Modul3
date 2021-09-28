using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stigespill_v2
{
    public class Model
    {
        public List<int> ladders;
        public int pos;
        //public CreateLadders createLadders;
        public Ladder ladderList;
        public DrawingSequence drawingSequence;
        //public List<int> row;

        public int rowNum;

        public int rowLength;
        public List<List<int>> listOfRows;

        public List<int> rows;

        public int currentPosition;
        public int nextPosition;
        public int position;

        public int startPosition = 1;


        //public Row drawingSequence;
        //public Board board;

        public Model()
        {
            //this.rowNum = rowNum;
            //this.rowLength = rowLength;
            position = startPosition;
            int rowLength = 9;

            ladderList = new Ladder();
            this.ladderList = ladderList;
            this.pos = 1;
            //ladderList.setLadderColors();


            drawingSequence = new DrawingSequence();
            listOfRows = new();

            createRows();
            

        }

        public void createRows()
        {
            int rowLength = 10;
            for (int i = 0; i < 10; i++)
            {
                //row = new();
                var row = drawingSequence.createRowDrawingSequence(i, rowLength - 1);
                listOfRows.Add(row);
            }
        }

    }
}




