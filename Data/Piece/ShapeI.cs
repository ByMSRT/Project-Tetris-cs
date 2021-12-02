using System;

namespace Project_Tetris_cs.Data.Piece {

    public class Barre : AllShape {

        public Barre() : base() {
            shape = new int[,] {{20, 0},{20, 1},{20, 2},{20, 3}};
        }
        
    }
    
}