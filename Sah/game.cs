using System;
using System.Collections.Generic;
using System.Text;

namespace Sah
{

    public class Game
    {
        //Naloga1
        //ustvarite 2 igralca ime naj bo igralec1 in igralec2, tipa Player (prvi napada Gor, drugi dopl)
        //imeni naj imata P1 in P2
        public Player igralec1 = new Player(smerNapada.Gor, "P1");
        public Player igralec2 = new Player(smerNapada.Dol, "P2");


        //pove kateri igralec je na potezi
        public int igralecNaPotezi = 1;

        public Game()
        {
            //dodajte začetne figure na šahovnico (8x8) 

            //Naloga1: dodajte samo kralja na pozicijo (5,1) igralcu 1 in pozicijo (5,8)
            //koda

            //Naloga3: dodajte vsakemu igralcu 3 figure (top,tekač in kralj) 
            //za kasneje
            //igralec1.dodajFiguro(new Rook(new ChessBoardField( 1, 1)));
            //igralec1.dodajFiguro(new Knight(new ChessBoardField(2, 1)));
            //igralec1.dodajFiguro(new Bishop(new ChessBoardField(3, 1)));
            //igralec1.odstraniFiguro(new ChessBoardField(3, 1));


            //igralec1.dodajFiguro(new Queen(new ChessBoardField(4, 1)));
            //igralec1.dodajFiguro(new King(new ChessBoardField(5, 1)));
            //igralec1.dodajFiguro(new Bishop(new ChessBoardField(6, 1)));
            //igralec1.dodajFiguro(new Knight(new ChessBoardField(7, 1)));
            //igralec1.dodajFiguro(new Rook(new ChessBoardField(8, 1)));

            //igralec2.dodajFiguro(new Rook(new ChessBoardField(1, 8)));
            //igralec2.dodajFiguro(new Knight(new ChessBoardField(2, 8)));
            //igralec2.dodajFiguro(new Bishop(new ChessBoardField(3, 8)));
            //igralec2.dodajFiguro(new Queen(new ChessBoardField(4, 8)));
            //igralec2.dodajFiguro(new King(new ChessBoardField(5, 8)));
            //igralec2.dodajFiguro(new Bishop(new ChessBoardField(6, 8)));
            ////igralec2.dodajFiguro(new Knight(new ChessBoardField(7, 8)));
            //igralec2.dodajFiguro(new Rook(new ChessBoardField(8, 8)));

        }

        //Naloga1
        //ustvarite javno metodo aktivniIgralec(), ki vrača igralca (tip Player), 
        //aktivnega igralca vrača na podlagi sprmenljivke igralecNaPotezi (1 igralec1, 2 igralec2)
        //koda
      /*  public Player aktivniIgralec()
        {
            //samo if  igralecNaPotezi
        }*/
        //analogno ustvarite metodo neaktivniIgralec, ki vrne neaktivnega igralca
     /*   public Player neaktivniIgralec()
        {
           
        }*/

        //Naloga1
        //Ustvarite metodo izrisiStanjeIgre, ki izpiše trenutno stanje na šahovnici (8x8)
        //ta metoda bo izrisala trenutno stanje postavitve figur
        //V OznakiFigure se nahaja oznaka figure, za igralca1 naj bodo izpisana z veliko, za drugega z malo (ToUpper, ToLower)
        //izpiše naj, kot je prikazano spodaj
        /*
            8  b kb
            7
            6
            5
            4
            3
            2
            1    KB
             12345678
         * */


        //Naloga1
        
        public void izrisiStanjeIgre()
        {
            //2dimnezionalna tabela
           


            //zadnja vrstica
            // Console.WriteLine(" 12345678");
        }



        public void igralecPremakne(ChessPiece figura, ChessBoardField pozicijanova)
        {
            //NALOGA2 
            //koda, ki premakne figuro na novo pozicijo in spremeni aktivnega igralca
            //igralecNaPotezi spremeni iz 1 v 2 ali iz 2
            //uprabite try/catch, v primeru, da premik ni mogoč (figura.Move vrne Exception), izpišite sporočilo
            //v primeru uporabe naključnih premikov, ne sme priti do exceptiona (če je vse ok)

            //koda!!!!!!!!
        }

        //Naloga3: ustvarite metodo narediPotezoNakljucno
        public void narediPotezoNakljucno()
        {
            //izberite naključno figuro aktivnega igralca iz seznama aktivniIgralec().MojeFigure
            //izberite naključno polje iz seznama dovoljenih premikov (uporabite dovoljeniPremikiIgra), vsebino metode shranite v začasni seznam
            //
            //v consolo izpišite, ustrezno glede na igralca
            //
            //      Console.WriteLine($" {aktivniIgralec().ime} Premik {figura.OznakaFigure.ToUpper/Lower} ({figura.Position.X},{figura.Position.Y}) na ({pozicijanova.X}, {pozicijanova.Y})");
            //kličite metodo igralecPremakne, ki izvede premik in spremni aktivnega igralca

            //Naloga3:
            //koda!!!!!!!!


            //klic premika igralecPremakne(figura, pozicijanova);

        }

      


    }

}
