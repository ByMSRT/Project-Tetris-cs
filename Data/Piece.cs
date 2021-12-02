using System;
using Project_Tetris_cs.Data.Piece;

namespace Project_Tetris_cs.Data {

    public class Tetris {

        // public object getRandomPiece() {
        //     allPiece = new object[7] {line, letterJ, letterL, block, letterS, letterT, letterZ};
        //     Random randomPiece = new Random();
        //     int randomPieceIndex = randomPiece.Next(0, allPiece.Length);
        //     Console.WriteLine(allPiece[randomPieceIndex]);
        //     return allPiece[randomPieceIndex];
        // }

        // public int[,] getCoordinates() {
        //     object pieceToGetCoordinate = getRandomPiece();
        //     int[,] pieceCoordinate = pieceToGetCoordinate.getPieceCoordinates();
        //     Console.WriteLine(pieceCoordinate);
        //     return pieceCoordinate;

        // }

        public object[] allPiece {get;set;}
        Barre line = new Barre();
        Gamma letterJ = new Gamma();
        LetterL letterL = new LetterL();
        Carre block = new Carre();
        ReverseBiais letterS = new ReverseBiais();
        LetterT letterT = new LetterT();
        Biais letterZ = new Biais();
        public Tetris() {
            allPiece = new object[7] {line, letterJ, letterL, block, letterS, letterT, letterZ};
        }
    }
}