using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChess
{
   
    public class Bishop : Piece
    {
        public string type;
        public string symbol;

        public Bishop() : base("LPR") { }          // Piece("TRN")
       

        public override bool Move(string fromPosition, string toPosition)
        {         
            
                var diffCol = fromPosition[0] - toPosition[0];
                var diffRow = fromPosition[1] - toPosition[1];
                return Math.Abs(diffRow) == Math.Abs(diffCol);
        }

    }
}
