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
        
    }
}
