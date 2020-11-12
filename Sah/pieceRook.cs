using System;
using System.Collections.Generic;
using System.Text;

namespace Sah
{
    public class Rook : ChessPiece
    {
        private const double chessWeight = 4.9;
        private const string oznakaFigure = "R";
        public Rook(ChessBoardField start) : base(start)
        {
            this.OznakaFigure = oznakaFigure;
            this.ChessWeight = chessWeight;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nMoje ime je {this.GetType()}";
        }


        /// <summary>
        /// Trdnjava se premika samo po linijah in vrstah
        /// </summary>
        /// <param name="field">Polje na plošči</param>
        public override void Move(ChessBoardField field)
        {
            // Pravilo za premik trdnjave
            if (this.Position.X != field.X && this.Position.Y != field.Y)
                throw new Exception("Nedovoljen premik!");

            base.Move(field);
        }

        //NALOGA2
        //koda tu ustvarite metodo dovoljeniPremikiIgra, ki bo prepisala abstraktno metodo dovoljeniPremikiIgra


    }
}
