using System;

namespace Project_Tetris_cs.Data.Piece {

    public class Carre : AllShape {
           
        public Carre() : base() {
            shape = new int[,] {{20, 0},{20, 1},{19, 0},{19, 1}};
        }
    }
    
}