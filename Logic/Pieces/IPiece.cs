using Logic.Enums;

namespace Logic.Pieces
{
    public interface IPiece
    {
        public Colour PieceSet { get; set; }
        public int[]? CurrentPosition { get; set; }

        public virtual (int, int)? GetCurrentPosition()
        {
            if (CurrentPosition == null)
            {
                return null;
            }
            return (CurrentPosition[0], CurrentPosition[1]);
        }

        List<(int, int)>? GetValidMoves();

        public static bool CheckPotentialPositionsAreInBounds(int[] potentialNewPosition)
        {
            return potentialNewPosition[0] >= 0
                    && potentialNewPosition[0] <= 7
                    && potentialNewPosition[1] >= 0
                    && potentialNewPosition[1] <= 7;
        }
        
    }
}
