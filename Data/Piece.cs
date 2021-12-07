using System;
using Project_Tetris_cs.Data.Piece;

namespace Project_Tetris_cs.Data {

    public class Tetris {

        // public int[][,] allPiece;
        public Barre line = new Barre();
        public Gamma letterJ = new Gamma();
        public LetterL letterL = new LetterL();
        public Carre block = new Carre();
        public ReverseBiais letterS = new ReverseBiais();
        public LetterT letterT = new LetterT();
        public Biais letterZ = new Biais();
        public Tetris() {
            //     new int[,] {line.shape},
            //     new int[][,] {letterJ.shape};
            //     new int[][,] {letterL.shape};
            //     new int[][,] {block.shape}
            // };
            // foreach(int i in line.shape) {
            //     Console.WriteLine(i);
            // }
        }

        private Random rnd = new Random();
        public AllShape getRandomPiece() {
            var arrayOfShape = new AllShape[] {line, letterJ, letterL, block, letterS, letterT, letterZ};
            int index = rnd.Next(arrayOfShape.Length);
            /* foreach(int test in arrayOfShape[index].shape) {
                Console.WriteLine(test);
            } */
            return arrayOfShape[index];
        }
        
    }
}