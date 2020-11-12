using System;
using System.Collections.Generic;
using System.Text;

namespace Sah
{  
    
    //SmerNapada bomo potrebovali pri Kmetu
    public enum smerNapada
    {
        Dol,
        Gor
    }

    public class Player
    {

        //dodajte public field, ime, kamor bo konstruktov vnesel ime igralca
        public string ime;
        //dodajte public property smernapada tipa smerNapada, ki ima samo get metodo
        public smerNapada smernapada { get; }

        //TODO ustvarite konstuktor, ki ima parameter smerNapada psmer, string pime
        //vhodna parametra vpiše v ustrezne spremenljivke
        public Player(smerNapada psmer, string pime)
        {
            ime = pime;
            smernapada = psmer;
        }


        /// <summary>
        /// Lastnost, ki vsebuje trenutne figure igralca
        /// </summary>

        //Seznam Figur, ki jih ima igralec
        public List<ChessPiece> MojeFigure { get; } = new List<ChessPiece>();

        //NALOGA
        //ustvarite metodo, ki bo dodala na seznam MyPieces figuro 
        //koda
        public void dodajFiguro(ChessPiece figura)
        {
            //dodajte preverbo, da igralec, še nima na tej poziciji figure, če jo ima je ne doda
            //za drugega igralca ni ptrebno preverjati
            MojeFigure.Add(figura);
        }


        //NALOGA1
        //ustvari javno metodo, ki ne vrača ničesar
        //metoda odstranila figuro iz seznama MojeFigure,
        //če obstaja figura na poziciji, ki podana kot vhodni parameter
        //izpišite (ConsoleWriteLine) ali je bila figura odstranje ali če ni bila odstranjena
        //koda
        public void odstraniFiguro(ChessBoardField ppozicija)
        {

            ChessPiece temp_figura = null;
            foreach (ChessPiece figura in MojeFigure)
            {
                if (figura.Position.X == ppozicija.X && figura.Position.Y == ppozicija.Y)
                {
                    temp_figura = figura;
                }
            }

            if (temp_figura != null)
            {
                Console.WriteLine($"Odstranjena figura igralca {ime} na pozicji: ({ppozicija.X},{ppozicija.Y}).");
                MojeFigure.Remove(temp_figura);
            }
            else
            {
                Console.WriteLine($"Igralec nima figure na pozicji: ({ppozicija.X},{ppozicija.Y}).");
            }

        }

    }
}
