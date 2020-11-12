using System;
using System.Collections.Generic;
using System.Text;

namespace Sah
{

    public class King : ChessPiece
    {
        private const double chessWeight = double.PositiveInfinity;
        private const string oznakaFigure = "K";

        public King(ChessBoardField start) : base(start)
        {
            this.OznakaFigure = oznakaFigure;
            this.ChessWeight = chessWeight;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nMoje ime je {this.GetType()}";
        }

        //TODO dodajte metodo premik, ki prepiše osnovon
        public override void Move(ChessBoardField field)
        {

            //Naloga2a
            // Pravilo za premik Kralja
            //koda

            //if (neustrezen premik)
            //    throw new Exception("Nedovoljen premik!");

            //ta naredi dejanski premik, če ni exceptiona
            base.Move(field);
        }


        //NALOGA2b
        //koda tu ustvarite metodo dovoljeniPremikiIgra, ki bo prepisala abstraktno metodo dovoljeniPremikiIgra


    }
}
