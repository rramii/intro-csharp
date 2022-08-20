namespace lesson_02
{
    internal class Program
    {
        static char ALIVE = '█';
        static char DEAD = '.';
        static void print(char[][] matrix)
        {

            for (int n = 0; n < matrix.Length; n++)
            {
                if (matrix[n].Length > 0)
                {
                    Console.Write(matrix[n][0]);
                }
                for (int k = 1; k < matrix[n].Length; k++)
                {
                    Console.Write(matrix[n][k]);
                }
                Console.WriteLine();
            }
        }

        /*static string check_nieghbors(string[][] pool, string main_cell)
        {
            for (int i = 0; i < 5; i++)
            {
                string nieghbors = { main_cell[][], main_cell[][], main_cell[][], main_cell[][] };
            }
        }*/

        static void Main(string[] args)
        {
            Console.WriteLine("begin");

            char[][] cells = new char[15][]
            {
                new char[] { DEAD , DEAD  , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD },
                new char[] { DEAD , DEAD  , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD },
                new char[] { DEAD , DEAD  , DEAD , ALIVE, DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD },
                new char[] { DEAD , DEAD  , DEAD , DEAD , ALIVE , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD },
                new char[] { DEAD , DEAD  , ALIVE , ALIVE , ALIVE , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD },
                new char[] { DEAD , DEAD  , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD },
                new char[] { DEAD , DEAD  , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD },
                new char[] { DEAD , DEAD  , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD },
                new char[] { DEAD , DEAD  , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD },
                new char[] { DEAD , DEAD  , DEAD , ALIVE , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD },
                new char[] { DEAD , DEAD  , DEAD , ALIVE , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD },
                new char[] { DEAD , DEAD  , DEAD , ALIVE , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD },
                new char[] { DEAD , DEAD  , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD },
                new char[] { DEAD , DEAD  , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD },
                new char[] { DEAD , DEAD  , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD , DEAD }
            };

            
            for (int i = 0; i < 10; i++)
            {
                print(cells);
                cells = next_generation(cells);
                Console.WriteLine("\n\n\n");
            }            
        }

        private static char[][] next_generation(char[][] cells)
        {
            char[][] result = new char[cells.Length][];
            for (int i = 0; i < cells.Length; i++)
            {
                result[i] = new char[cells[i].Length];
                for (int j = 0; j < cells[i].Length; j++)
                {
                    int alive = count_alive(cells, i, j);
                    if (cells[i][j] == DEAD && alive == 3)
                    {
                        result[i][j] = ALIVE;
                    }
                    else if (cells[i][j] == ALIVE && (alive == 3 || alive == 4))
                    {
                        result[i][j] = ALIVE;
                    }
                    else
                    {
                        result[i][j] = DEAD;
                    }
                }
            }

            return result;
        }

        private static int count_alive(char[][] cells, int row, int column)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    int n_row = row + i;
                    int n_col = column + j;
                    if (inside_array(cells, n_row, n_col))
                    {
                        if (cells[n_row][n_col] == ALIVE)
                        {
                            count += 1;
                        }
                    }
                }
            }

            return count;
        }

        private static bool inside_array(char[][] cells, int n_row, int n_col)
        {
            if (n_row < 0 || n_row >= cells.Length)
            {
                return false;
            }

            if (n_col < 0 || n_col >= cells[n_row].Length)
            {
                return false;
            }
            return true;
        }
    }
}