namespace lesson_02
{
    internal class Program
    {
        static void pprint(string[][] matrix)
        {
            Console.WriteLine("{");
            for (int n = 0; n < matrix.Length; n++)
            {
                if (matrix[n].Length > 0)
                {
                    Console.Write($" [ {matrix[n][0]}");
                }
                for (int k = 1; k < matrix[n].Length; k++)
                {
                    Console.Write($" , {matrix[n][k]}");
                }
                Console.WriteLine(" ] ");
            }
            Console.WriteLine("}");
        }

        static string check_nieghbors(string[][] pool, string main_cell)
        {
            for (int i = 0; i < 5; i++)
            {
                string nieghbors = { main_cell[][], main_cell[][], main_cell[][], main_cell[][] };
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("begin");

            string[][] cells = new string[15][] 
            {
                new string[] { "_" , "_"  , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" }, 
                new string[] { "_" , "_"  , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" }, 
                new string[] { "_" , "_"  , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" }, 
                new string[] { "_" , "_"  , "_" , "_" , "#" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" }, 
                new string[] { "_" , "_"  , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" }, 
                new string[] { "_" , "_"  , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" }, 
                new string[] { "_" , "_"  , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" }, 
                new string[] { "_" , "_"  , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" }, 
                new string[] { "_" , "_"  , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" }, 
                new string[] { "_" , "_"  , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" }, 
                new string[] { "_" , "_"  , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" }, 
                new string[] { "_" , "_"  , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" }, 
                new string[] { "_" , "_"  , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" }, 
                new string[] { "_" , "_"  , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" }, 
                new string[] { "_" , "_"  , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" , "_" }
            };

            for (int i = 0; i < cells.Length; i++)
            {
                for (int k = 0; k < cells[i].Length; k++)
                {
                    string cel = cells[i][k];
                    while (cel == "#")
                    {
                        string nieghbors = check_nieghbors(cells, cells[i][k]);
                        if (nieghbors.Length > 3 || nieghbors.Length < 2)
                        {
                            string cel = "_";
                        }
                    }
                }
            }
            pprint(cells);
        }
    }
}