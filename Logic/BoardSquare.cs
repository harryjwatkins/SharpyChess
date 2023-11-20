using Logic.Enums;
using Logic.Pieces;

namespace Logic
{
    public class BoardSquare
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public Colour Colour { get; set; }
        public IPiece? Piece { get; set; }

        public BoardSquare(int row, int col, Colour colour)
        {
            Row = row;
            Col = col;
            Colour = colour;
        }
    }
}
