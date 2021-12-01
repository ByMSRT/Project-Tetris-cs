using System;

namespace Tetris {
    public class Grid {
        public int row {get; set;}

        public int column {get; set;}

        public int[,] finallyGrid;

        // Construction de la grille finale 

        public Grid() {
            finallyGrid = new int[row, column];
        }

        public Grid(int row, int column) {
            this.row = row;
            this.column = column;
            finallyGrid = new int[row, column];
        }
        // public Grid buildGrid() {
        //     finallyGrid = new int[row, column];
        //     return finallyGrid;
        // }


    }
}