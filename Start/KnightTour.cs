using System;

namespace Start
{
    //обход коня
    public class KnightTour
    {
        private static readonly int[][] MoveVariations =
        {
            new[] {-1, 2},
            new[] {1, 2},
            new[] {-2, 1},
            new[] {-2, -1},
            new[] {-2, 1},
            new[] {-2, -1},
            new[] {2, 1},
            new[] {2, -1}
        };

        private const int PossibleMoveCombinations = 8;

        private readonly int _numberOfColumns;

        public KnightTour(int numberOfColumns)
        {
            _numberOfColumns = numberOfColumns;
        }

        public int[,] Start(int startX, int startY)
        {
            if (startX < 0 || startY < 0 || startX > _numberOfColumns - 1 || startY > _numberOfColumns - 1)
            {
                throw new ArgumentException("Wrong arguments!");
            }

            var board = new int[_numberOfColumns, _numberOfColumns];

            Move(board, startX, startY, 0);

            return board;
        }

        private void Move(int[,] board, int x, int y, int moveNumber)
        {
            board[x, y] = moveNumber++;

            int i = PossibleMoveCombinations;

            while (--i >= 0)
            {
                int[] a = MoveVariations[i];
                int iX = x + a[0];
                int iY = y + a[1];

                if (iX >= 0 && iY >= 0 && iX < _numberOfColumns && iY < _numberOfColumns && board[iX, iY] == 0)
                {
                    Move(board, iX, iY, moveNumber);
                }
            }
        } 
    }
}