using System;
using System.Collections.Generic;
using System.Text;

namespace Sah
{

    //TODO ustvarite razred pieceRunner z vsemi potrebnimi metodami
    public class Bishop : ChessPiece
    {
        private const double chessweight = 3;
        private const string oznakaFigure = "B";
        public Bishop(ChessBoardField start) : base(start)
        {
            this.OznakaFigure = oznakaFigure;
            this.ChessWeight = 3;
        }


        //TODO prepišite metodo move
        public override void Move(ChessBoardField field)
        {
            //Naloga2a
            //Pravilo za premik Kralja
            //koda
            //giblje se lahko po diagonalah

            //namig this.Position trenutna pozicija, field nova pozicija
            
            
            //if (neustrezen)
            //    throw new Exception("Nedovoljen premik!");

            base.Move(field);
        }


        //NALOGA2
        //koda tu ustvarite metodo dovoljeniPremikiIgra, ki bo prepisala abstraktno metodo dovoljeniPremikiIgra



    }
}
