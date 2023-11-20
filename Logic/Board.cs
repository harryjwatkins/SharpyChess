using Logic.Enums;
using Logic.Pieces;

namespace Logic
{
    public class Board
    {
        BoardSquare[,] board = new BoardSquare[8, 8];

        public Board()
        {
            // Construct the empty board
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        board[i, j] = new BoardSquare(i, j, Colour.White);
                    }
                    else
                    {
                        board[i, j] = new BoardSquare(i, j, Colour.Black);
                    }
                }
            }
        }

        public void SetBoardStartingPosition()
        {
            // Pawns
            for (int column = 0; column < 8; column++)
            {
                int[] blackPawnSquare = new int[] { 1, column };
                int[] whitePawnSquare = new int[] { 6, column };
                board[1, column].Piece = new Pawn(Colour.Black, blackPawnSquare, false);
                board[6, column].Piece = new Pawn(Colour.White, whitePawnSquare, false);
            }

            // Rooks
            board[0, 0].Piece = new Rook(Colour.Black, new int[] { 0, 0 });
            board[0, 7].Piece = new Rook(Colour.Black, new int[] { 0, 7 });
            board[7, 0].Piece = new Rook(Colour.White, new int[] { 7, 0 });
            board[7, 7].Piece = new Rook(Colour.White, new int[] { 7, 7 });

            // Knights
            board[0, 1].Piece = new Knight(Colour.Black, new int[] { 0, 1 });
            board[0, 6].Piece = new Knight(Colour.Black, new int[] { 0, 6 });
            board[7, 1].Piece = new Knight(Colour.White, new int[] { 7, 1 });
            board[7, 6].Piece = new Knight(Colour.White, new int[] { 7, 6 });

            // Bishops
            board[0, 2].Piece = new Bishop(Colour.Black, new int[] { 0, 2 });
            board[0, 5].Piece = new Bishop(Colour.Black, new int[] { 0, 5 });
            board[7, 2].Piece = new Bishop(Colour.White, new int[] { 7, 2 });
            board[7, 5].Piece = new Bishop(Colour.White, new int[] { 7, 5 });

            // Queen
            board[0, 3].Piece = new Queen(Colour.Black, new int[] { 0, 3 });
            board[7, 3].Piece = new Queen(Colour.White, new int[] { 7, 3 });

            // King
            board[0, 4].Piece = new King(Colour.Black, new int[] { 0, 4 });
            board[7, 4].Piece = new King(Colour.White, new int[] { 7, 4 });
        }

        public void MovePiece(IPiece piece, int[] newPosition)
        {

        }

        public IPiece? GetBoardSquarePiece(int row, int column)
        {
            if (board[row, column] == null)
            {
                return null;
            }
            return board[row, column].Piece;
        }
    }
}
