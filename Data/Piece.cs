using System;
using System.Timers;
using Project_Tetris_cs.Data.Piece;

namespace Project_Tetris_cs.Data {

    public class Tetris {
        public Barre line = new Barre();
        public Gamma letterJ = new Gamma();
        public LetterL letterL = new LetterL();
        public Carre block = new Carre();
        public ReverseBiais letterS = new ReverseBiais();
        public LetterT letterT = new LetterT();
        public Biais letterZ = new Biais();

        public AllShape[] arrayOfShape;

        public Tetris() {}
    
    }
}