using System;
using System.Collections.Generic;
using System.Text;

namespace Sah
{

    interface IPiece
    {
        /// <summary>
        /// Vsaka figura se zna premakniti na neko polje
        /// </summary>
        /// <param name="field">Polje, kamor se naj figura premakne</param>
        void Move(ChessBoardField field);

        /// <summary>
        /// Vmesniki definirajo tudi lastnosti v enaki obliki, 
        /// kot v razredu definiramo samodejno implementirane lastnosti.
        /// Vendar moramo lastnosti vmesnika dejansko implementirati v razredu.
        /// </summary>
      
        double ChessWeight { get; }

        ChessBoardField Position { get; }
    }

    /// <summary>
    /// Definiramo si struct za shranjevanje koordinat na šahovski plošči
    /// </summary>
    public class ChessBoardField
    {
        /// <summary>
        /// Vodoravna koordinata
        /// </summary>
        public ChessBoardField(int p_x, int p_y)
        {
            X = p_x;
            Y = p_y;
        }

        public string oznaka { get; set; }

        public int X { get; set; }

        /// <summary>
        /// Navpična koordinata
        /// </summary>
        public int Y { get; set; }

        public override string ToString()
        {
            return $"({this.X},{this.Y})";
        }
    }


    /// <summary>
    /// V tem primeru naj razred implementira vmesnik IPiece,
    /// zato moramo implementirati tudi vse zahtevane metode in lastnosti vmesnika
    /// </summary>
    public abstract class ChessPiece : IPiece
    {
        public ChessPiece(ChessBoardField start)
        {
            this.position = start;
        }

        public double ChessWeight { get; protected set; }
        //oznaka figure, bo predstavljala String, ki se bo izpisovl
        public string OznakaFigure { get; protected set; }



        public override string ToString()
        {
            return $"Sem šahovska figura z vrednostjo {this.ChessWeight}.";
        }

        /// <summary>
        /// Implementiramo metodo za premik figure.
        /// Vsaka figura ima svoja pravila za premike, 
        /// zato bomo to metodo zelo verjetno v vsakem izmed podrazredov prepisali ("override").
        /// V ta namen jo označimo za virtualno.
        /// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual?f1url=%3FappId%3DDev16IDEF1%26l%3DEN-US%26k%3Dk(virtual_CSharpKeyword);k(DevLang-csharp)%26rd%3Dtrue
        /// </summary>
        /// <param name="field">Polje, kamor naj se figura premakne</param>
        public virtual void Move(ChessBoardField field)
        {
            position = field;

        }

        //Naloga2
        //ustvarite opis abstaktne metode tipa List<ChessBoardField> ime naj ima dovoljeniPremikiIgra
        //dobi vhodna parametra (Player jaz, Player nasprotnik);
        //koda (1 vrstica)



        //Naloga2: izpis premikov
        //koda, izpiše dovoljene premike metode dovoljeniPremikiIgra



        //Naloga4
        //seznam figur, ki jih lahko požrem napolni se v metodi dovoljeniPremikiIgra!
        //public List<ChessBoardField> dovoljeniPremikiIgraPozrem;


        /// <summary>
        /// Implementirana lastnost mora biti zapisana eksplicitno
        /// </summary>
        private ChessBoardField position;
        public ChessBoardField Position
        {
            get
            {
                return position;
            }
            /*private set 
            {
                position = value;
            } */
        }
    }


}
