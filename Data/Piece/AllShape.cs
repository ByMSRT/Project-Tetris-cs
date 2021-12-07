using System;
using System.Timers;
namespace Project_Tetris_cs.Data.Piece {
    public class AllShape {
        public int[] shape {get; set;}

        // private Timer timerToMoveShape = new Timer(1500);
        public AllShape() {}

        // public void movePieceDownTimer() {
        //     if (timerToMoveShape.Enabled) {
        //         return;
        //     }
        //     timerToMoveShape.Elapsed += movePieceDown;
        //     timerToMoveShape.AutoReset = true;
        //     timerToMoveShape.Enabled = true;
        // }

        public void movePieceDown() {
            // Boucle en arrière pour conditions après car shape dans l'ordre décroissant
            for (int index = this.shape.Length-1; index >= 0; index--) {
                if (this.shape[index] >= 10 && this.shape[index] <= 200) {
                    this.shape[index] -= 10;
                } else {
                    break;
                } 
            }
        }

        public void movePieceLeft() {
            // Boucle en arrière pour conditions après car shape dans l'ordre décroissant
            for (int index = this.shape.Length-1; index >= 0; index--) {
                if (this.shape[index] >= 10 && this.shape[index] <= 200) {
                    if (this.shape[index] >= 191 && this.shape[index] >= 181){
                        this.shape[index] -= 1;
                    }
                    
                } else {
                    break;
                }          
            }
        }

        public void movePieceRight() {
            // Boucle en arrière pour conditions après car shape dans l'ordre décroissant
            for (int index = this.shape.Length-1; index >= 0; index--) {
                if (this.shape[index] >= 10 && this.shape[index] <= 200) {
                        this.shape[index] += 1;
                } else {
                    break;
                }          
            }
        }
    }
}