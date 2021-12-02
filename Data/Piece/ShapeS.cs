using System;

namespace Project_Tetris_cs.Data.Piece {

    public class ReverseBiais : AllShape {
        public ReverseBiais() : base() {
            shape = new int[,] {{19, 0},{19, 1},{20, 1},{20, 2}};
        }
    }
    
}