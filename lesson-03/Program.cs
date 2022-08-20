namespace lesson_03
{
    internal class Life
    {
        private CellState[,] matrix;
        public Life(int rows, int columns)
        {
            matrix = new CellState[rows, columns];
        }

        public void next_generation()
        {
            throw new NotImplementedException();
        }

        public void turnon(int row, int col)
        {
            //TODO: check row/col are legal
            matrix[row, col] = CellState.IsAlive;
        }

        public void turnof(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public void print()
        {
            throw new NotImplementedException();
        }
    }
}