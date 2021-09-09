using System;

namespace SimpleChess
{
        public abstract class Piece
        {
            public string Symbol { get; }

            public Piece(string symbol)
            {
                Symbol = symbol;
            }

            public abstract bool Move(string fromPosition, string toPosition);
        }
    }

    