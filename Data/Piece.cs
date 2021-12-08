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

        // private Timer timerToMoveShape = new Timer();

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

        public void getRandomPiece() {
            var arrayOfShape = new AllShape[] {line, letterJ, letterL, block, letterS, letterT, letterZ};
        }

        // public void movePieceDownTimer() {
        //     timerToMoveShape.Interval = 1000;
        //     timerToMoveShape.Elapsed +=  new ElapsedEventHandler(movePieceDown);
        //     timerToMoveShape.AutoReset = true;
        //     timerToMoveShape.Enabled = true;
        // }

        // public void movePieceDown(object source, ElapsedEventArgs e) {
        //     // Boucle en arrière pour conditions après car shape dans l'ordre décroissant
        //     for (int index = block.shape.Length; index >= 0; index--) {
        //         if (block.shape[index] >= 0) {
        //             block.shape[index]--;
        //         } 
        //     }
        // }
        
    }
}