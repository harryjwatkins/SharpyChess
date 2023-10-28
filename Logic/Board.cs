using Logic.Enums;

namespace Logic
{
    public class Board
    {
        int[,] board = new int[8, 8];

        public Board()
        {
            // Construct the empty board
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                   if((i + j) % 2 == 0)
                    {
                        board[i, j] = 0;
                    }
                    else
                    {
                        board[i, j] = 1;
                    }
                }
            }

            // Fill the board with starting positions

            // Pawns
            for (int column = 0;  column < 8; column++)
            {
                int[,] blackPawnSquare = new int[1, column];
                int[,] whitePawnSquare = new int[7, column];
                new Piece(PieceType.Pawn, PieceSet.Black, blackPawnSquare);
                new Piece(PieceType.Pawn, PieceSet.White, whitePawnSquare);
            }

            // Rooks
            new Piece(PieceType.Rook, PieceSet.Black, new int[0,0]);
            new Piece(PieceType.Rook, PieceSet.Black, new int[0, 7]);
            new Piece(PieceType.Rook, PieceSet.White, new int[7, 0]);
            new Piece(PieceType.Rook, PieceSet.White, new int[7, 7]);

            // Knights
            new Piece(PieceType.Knight, PieceSet.Black, new int[0, 1]);
            new Piece(PieceType.Knight, PieceSet.Black, new int[0, 6]);
            new Piece(PieceType.Knight, PieceSet.White, new int[7, 1]);
            new Piece(PieceType.Knight, PieceSet.White, new int[7, 6]);

            // Bishops
            new Piece(PieceType.Bishop, PieceSet.Black, new int[0, 2]);
            new Piece(PieceType.Bishop, PieceSet.Black, new int[0, 5]);
            new Piece(PieceType.Bishop, PieceSet.White, new int[7, 2]);
            new Piece(PieceType.Bishop, PieceSet.White, new int[7, 5]);

            // Queen
            new Piece(PieceType.Queen, PieceSet.Black, new int[0, 3]);
            new Piece(PieceType.Queen, PieceSet.White, new int[7, 3]);

            // Queen
            new Piece(PieceType.Queen, PieceSet.Black, new int[0, 3]);
            new Piece(PieceType.Queen, PieceSet.White, new int[7, 3]);
        }
    }
}
