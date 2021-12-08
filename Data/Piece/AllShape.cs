namespace Project_Tetris_cs.Data.Piece {
    public class AllShape {
        public int[] shape {get; set;}

        private int[] border;

        public AllShape() {}

        public int[] completeBorder(int minimum, int maximum) {
            for (int index = minimum; index <= maximum; index++) {
                border[index-1] = index + 10;
            }
            return border;
        }

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
                if ((this.shape[index]-1) % 10 == 0) {
                    break;
                } else {
                    this.shape[index]--;
                }
               
            }
        }

        public void movePieceRight() {
            // Boucle en arrière pour conditions après car shape dans l'ordre décroissant
            for (int index = 0; index < this.shape.Length; index++) {
                if (this.shape[index] % 10 == 0) {
                    break;
                } else {
                    this.shape[index]++;
                }
            }     
            
        }
    }
}