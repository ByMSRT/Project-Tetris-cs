using System;

namespace Project_Tetris_cs.Data.Piece {

    public class Gamma : AllShape {
        
        public Gamma() : base() {
            shape = new int[,] {{20, 0},{20, 1},{20, 2},{19, 2}};
        }
    }
    
}