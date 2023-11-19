using Logic.Enums;

namespace Logic.Pieces
{
    public class Bishop : IPiece
    {
        public Colour PieceSet {  get; set; }
        public int[]? CurrentPosition {  get; set; }
        public Bishop(Colour pieceSet, int[] currentPosition) 
        {
            PieceSet = pieceSet;
            CurrentPosition = currentPosition;
        }

        public List<(int, int)>? GetValidMoves()
        {
            var validMoves = new List<(int, int)>();

            return validMoves;
        }
    }
}
