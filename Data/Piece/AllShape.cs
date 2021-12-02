using System;
namespace Project_Tetris_cs.Data.Piece {
    public class AllShape {
        public int[,] shape {get; set;}
        public int[,] getShapeCoordinates() {
            return shape;
        }

        public AllShape() {
        }
    }
}