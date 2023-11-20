using Logic.Enums;

namespace Logic.Pieces
{
    public class Knight : IPiece
    {
        public Colour PieceSet {  get; set; }
        public int[]? CurrentPosition {  get; set; }

        private List<(int, int)> _potentialMoves = new List<(int, int)>()
        {
            (2,1), (2,-1),
            (-2,1), (-2,-1),
            (1,2), (1,-2),
            (-1,2), (-1,-2)
        };
        public Knight(Colour pieceSet, int[] currentPosition) 
        {
            PieceSet = pieceSet;
            CurrentPosition = currentPosition;
        }

        public List<(int, int)>? GetValidMoves()
        {
            if (CurrentPosition == null) {
                return null;
            }

            var validMoves = new List<(int, int)>();

            foreach (var potentialMove in _potentialMoves)
            {
                int[] potentialNewPosition = new int[2] 
                { 
                    CurrentPosition[0] + potentialMove.Item1, CurrentPosition[1] + potentialMove.Item2 
                };
                if (IPiece.CheckPotentialPositionsAreInBounds(potentialNewPosition))
                {
                    validMoves.Add(potentialMove);
                }
            }

            return validMoves;
        }
    }
}
