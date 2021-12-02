using System;

namespace Project_Tetris_cs.Data.Piece {

    public class Biais : AllShape {
        public Biais() : base() {
            this.shape = new int[,] {{20, 0},{20, 1},{19, 1},{19, 2}};
        }
    }
    
}