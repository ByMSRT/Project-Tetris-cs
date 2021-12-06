using System;

namespace Project_Tetris_cs.Data {
    public class Grid {
        public int row {get; set;}
        public int column {get; set;}
        // Tableau à double dimension
        public int[,] finallyGrid;

        // Construction de la grille finale 
        public Grid(int row, int column) {
            this.row = row;
            this.column = column;
            finallyGrid = new int[row, column];
        }

    }
}