using Logic.Enums;

namespace Logic.Pieces
{
    public class Pawn : IPiece
    {
        public Colour PieceSet {  get; set; }
        public int[]? CurrentPosition {  get; set; }
        public bool HadFirstMove {  get; set; }
        public Pawn(Colour pieceSet, int[] currentPosition, bool hadFirstMove) 
        {
            PieceSet = pieceSet;
            CurrentPosition = currentPosition;
            HadFirstMove = hadFirstMove;
        }

        public List<(int, int)>? GetValidMoves()
        {
            if (!HadFirstMove)
            {
                return PieceSet switch
                {
                    Colour.Black => new List<(int, int)>() { (0, 2), (0, 1) },
                    _ => new List<(int, int)> { (0, -2), (0, -1) }
                };
            }
            else
            {
                return PieceSet switch
                {
                    Colour.Black => new List<(int, int)>() {(0, 1) },
                    _ => new List<(int, int)> {(0, -1) }
                };
            }
        }
    }
}
