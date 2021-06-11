using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChess
{
    class Rook : Piece
    {
        // var rook = new Piece("Rook", "TRN");
        public Rook() : base("TRN") { } // Base keyword is used to access members of the base class from within a derived class.

        public override bool Move(string fromPosition, string toPosition)
        {
            //if (_type == "Rook") return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }
    }
}
