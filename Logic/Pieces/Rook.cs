using Logic.Enums;

namespace Logic.Pieces
{
    public class Rook : IPiece
    {
        public Colour PieceSet { get; set; }
        public int[]? CurrentPosition { get; set; }
        public Rook(Colour pieceSet, int[] currentPosition)
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
