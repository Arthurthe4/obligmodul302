using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChess
{
    class Bishop : Piece
    {
        // var bishop = new Piece("Bishop", "LPR");
        public Bishop() : base("LPR"){} // Base keyword is used to access members of the base class from within a derived class.

        public override bool Move(string fromPosition, string toPosition)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
            return Math.Abs(diffRow) == Math.Abs(diffCol);
        }

        //public bool Move(string fromPosition, string toPosition)
        //{
        //    if (_type == "Rook") return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        //    if (_type == "Bishop")
        //    {
        //        var diffCol = fromPosition[0] - toPosition[0];
        //var diffRow = fromPosition[1] - toPosition[1];
        //        return Math.Abs(diffRow) == Math.Abs(diffCol);
        //    }
        //    return true;
        //}
    }
}
