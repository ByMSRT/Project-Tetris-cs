using System;
using Project_Tetris_cs.Data.Piece;

namespace Project_Tetris_cs.Data {
    public class Grid {
        private int cell = 1;
        public int row {get; set;}

        public int column {get; set;}

        // Tableau à double dimension
        public int[,] finallyGrid;

        // Construction de la grille finale 
        public Grid(int row, int column) {
            this.row = row;
            this.column = column;
            this.finallyGrid = new int[row, column];
            for (int indexRow = 0; indexRow < row; indexRow++) {
                for (int indexColumn = 0; indexColumn < column; indexColumn++) {
                    finallyGrid[indexRow, indexColumn] = cell;
                    cell++;
                }
            }
        }
    }
}