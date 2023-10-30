using Logic.Enums;

namespace Logic
{
    public class BoardSquare
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public Colour Colour { get; set; }
        public Piece? Piece { get; set; }

        public BoardSquare(int row, int col, Colour colour) 
        {
            Row = row; 
            Col = col; 
            Colour = colour;
        }
    }
}
