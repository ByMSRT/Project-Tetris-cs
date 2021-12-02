using System;
using Project_Tetris_cs.Data.Piece;

namespace Project_Tetris_cs.Data {
    public class Grid {
        public int row {get; set;}

        public int column {get; set;}

        // Tableau à double dimension
        public int[][] finallyGrid;

        // Construction de la grille finale 
        public Grid(int row, int column) {
            this.row = row;
            this.column = column;
            this.finallyGrid = new int[row][];
            for (int index = 1; index <= row; index++) {
                for (int index2 = 1; index2 <= column; index2++) {
                    finallyGrid[index] = new int[index2];
                    finallyGrid[index][index2] = 0;
                }
            }
            // for (int indexRow = 1; indexRow <= row; indexRow++) {
            //     for (int indexColumn = 1; indexColumn <= column; indexColumn++) {
            //         this.finallyGrid[indexRow, indexColumn] = 0 ;
                    
            //     }
            // }
            // foreach(int index in finallyGrid) {
            //     Console.WriteLine(index);
            // }
            // Console.WriteLine(finallyGrid);

        }

        

    }
}