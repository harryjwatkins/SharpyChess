using Logic.Enums;

namespace Logic
{
    public class Piece
    {
        public PieceType PieceType { get; set; }
        public Colour PieceSet { get; set; }
        public int[]? CurrentPosition { get; set; }
        public bool HadFirstMove = false;

        public Piece(PieceType pieceType, Colour pieceSet, int [] currentPosition) 
        {
            PieceType = pieceType;
            PieceSet = pieceSet;
            CurrentPosition = currentPosition;
        }

        public int[]? GetCurrentPosition()
        {
            if (CurrentPosition == null)
            {
                return null;
            }
            return CurrentPosition;
        }
    }
}
