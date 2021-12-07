using System;
using System.Timers;
namespace Project_Tetris_cs.Data.Piece {
    public class AllShape {
        public int[] shape {get; set;}

        private Timer timerToMoveShape = new Timer();


        public AllShape() {}

        // public void movePieceDownTimer() {
        //     timerToMoveShape.Interval = 1000;
        //     timerToMoveShape.Elapsed +=  new ElapsedEventHandler(movePieceDown);
        //     timerToMoveShape.AutoReset = true;
        //     timerToMoveShape.Enabled = true;
        //     timerToMoveShape.Start();
        // }

        public void movePieceDown() {
            // Boucle en arrière pour conditions après car shape dans l'ordre décroissant
            for (int index = shape.Length; index >= 0; index--) {
                if (shape[index] >= 0) {
                    shape[index] = shape[index] - 10;
                }
            }
            Console.WriteLine("Hello World");
        }
    }
}