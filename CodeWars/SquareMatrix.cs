namespace CodeWars
{
    internal class SquareMatrix
    {
        private int size;
        private int[][] values;
        private int determinant;

        public SquareMatrix(int size)
        {
            this.size = size;
            determinant = int.MinValue;
            values = new int[size][];
            for (int i = 0; i < size; i++)
            {
                values[i] = new int[size];
            }
        }
        public SquareMatrix(int[][] matrix)
        {
            if (matrix.Length == matrix[0].Length)
            {
                determinant = int.MinValue;
                values = matrix;
                size = matrix.Length;
            }
            else
                throw new ArgumentException("Передаваемая в аргументе матрица не является квадратной.");
        }
        public SquareMatrix(int[,] array)
        {
            if (array.GetLength(0) == array.GetLength(1))
            {
                determinant = int.MinValue;
                size = array.GetLength(0);
                int N = array.GetLength(0);
                values = new int[N][];
                for (int i = 0; i < N; i++)
                {
                    values[i] = new int[N];
                }
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        values[i][j] = array[i, j];
                    }
                }
            }
            else
                throw new ArgumentException("Передаваемая в аргументе матрица не является квадратной.");
        }
        public void SetValue(int row, int column, int value)
        {
            if (row < 0 || column < 0 || row > size || column > size)
                throw new ArgumentException("Индекс за пределами матрицы.");
            else
            {
                values[row][column] = value;
                determinant = int.MinValue;
            }

        }
        public int GetValue(int row, int column)
        {
            if (row < 0 || column < 0 || row > size || column > size)
                throw new ArgumentException("Индекс за пределами матрицы.");
            else
                return values[row][column];
        }
        public int GetDeterminant()
        {
            if (determinant == int.MinValue)
                determinant = CalculateDeterminant(values);

            return determinant;
        }

        private int CalculateDeterminant(int[][] matrix)
        {
            if (matrix.Length == 1)
                return matrix[0][0];

            if (matrix.Length == 2)
                return matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0];


            int[][][] minors = new int[matrix.Length][][];
            int N = matrix.Length - 1;
            for (int i = 0; i < matrix.Length; i++)
            {
                int[][] minor = new int[N][];
                int minor_i = 0, minor_j = 0;
                for (int x = 1; x < matrix.Length; x++)
                {
                    minor[minor_i] = new int[N];
                    for (int y = 0; y < matrix[x].Length; y++)
                    {
                        if (y != i)
                            minor[minor_i][minor_j++] = matrix[x][y];
                    }
                    minor_i++;
                    minor_j = 0;
                }
                minors[i] = minor;
            }
            int det = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                int c = i % 2 == 0 ? 1 : -1;
                det += c * matrix[0][i] * CalculateDeterminant(minors[i]);
            }
            return det;
        }
    }
}
