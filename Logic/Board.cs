namespace Logic
{
    public class Board
    {
        int[,] board = new int[8, 8];

        public Board()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                   if((i + j) % 2 == 0)
                    {
                        board[i, j] = 0;
                    }
                    else
                    {
                        board[i, j] = 1;
                    }
                }
            }
        }
    }
}
