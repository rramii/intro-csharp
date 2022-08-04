
namespace lesson_01
{
    internal class Program
    {
        /*static void variables()
        {
            sbyte bite = 127;          // -128..127


             negative and positive
            short hair = -32768;       // -32768..0..+32767
            int number = 31415;
            long many = 3476378967867345;
            number = 781;

            double distance_to_pluto = 5.91E11;
            double au = 1.49e11;

            double distance_london_hafia = 4.352_380e123;



            Console.WriteLine($"{distance_london_hafia}");
            double r = distance_london_hafia + 391.5;
            Console.WriteLine($"{distance_london_hafia == r}");


            positive
            byte chips = 255;
            ushort tail = 65_535;  // 0..2^16 - 1
            uint ger = 4294967295;  // 0..2^32 - 1     
            ulong life = 18_446_744_073_709_551_615; // 0..2^63-1

        }*/

        /*static void chars()
        {
            Console.WriteLine(4_300);
            int x = 72;
            double y = 72.0;
            bool is_bigger = true;
            Console.WriteLine(is_bigger);
            is_bigger = x > y;
            Console.WriteLine(is_bigger);


            char coal = 'Ж';
            Console.WriteLine(coal);

            char smily = 'श'; //  '😀';
            Console.WriteLine(smily);


            string message = "hello world!  😀 😷";
            Console.WriteLine(message);
        }*/

        static int average(int x, int y, int z)
        {
            return (x + y + z) / 3;
        }

        static void print(double[] list)
        {
            if (list is null)
            {
                Console.WriteLine("Nothing");
                return;
            }

            Console.Write("[ ");

            if (list.Length > 0)
            {
                Console.Write($"{list[0]}");
            }

            for (int i = 1; i < list.Length; i++)
            {
                Console.Write($", {list[i]}");
            }
            Console.Write(" ]");
        }

        static void pprint(double[,] matrix)
        {
            Console.WriteLine("{");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix.GetLength(1) > 0)
                {
                    Console.Write($" [ {matrix[i, 0]}");
                }
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    Console.Write($", {matrix[i, j]}");
                }
                Console.WriteLine(" ]");
            }
            Console.WriteLine("}");
        }

        static void pprint(double[][] matrix)
        {
            for (int n = 0; n < matrix.Length; n++)
            {
                for (int k = 0; k < matrix[n].Length; k++)
                {
                    System.Console.Write(matrix[n][k]);
                }
                System.Console.WriteLine();
            }
        }
        static double sum(double[] list)
        {

            double summary = 0.0;
            if (list.Length == 0.0)
            {
                Console.Write("list is empty");
            }

            else
            {
                for (int i = 0; i < list.Length; i++)
                {
                    summary += list[i];
                }
            }
            return summary;
        }

        static void println(int[] list)
        {
            if (list is null)
            {
                Console.WriteLine("Nothing");
                return;
            }

            Console.Write("[ ");

            if (list.Length > 0)
            {
                Console.Write($"{list[0]}");
            }

            for (int i = 1; i < list.Length; i++)
            {
                Console.Write($", {list[i]}");
            }
            Console.Write(" ]");
        }

        static double avg(double[] lst)
        {
            if (lst.Length == 0.0)
            {
                Console.Write("list is empty");
            }

            return sum(lst) / lst.Length;
        }

        static double power(double num, double pow)
        {
            for (int i = 1; i < pow+1; i++)
            {
                num *= num;
            }
            return num;
        }

        static void quadratic(double[] list)
        {
            if (list.Length == 3)
            {
                double disc = list[1] * list[1] - 4 * list[0] * list[2];
                double root = power(disc, 0.5); //math.Pow(disc, 0.5)
                double solve1 = (-list[1] + root) / (2 * list[0]);
                double solve2 = (-list[1] - root) / (2 * list[0]);
                double solve3 = -list[1] / (2 * list[0]);

                if (list[0] == 0)
                {
                    Console.WriteLine("not quadratic equation");
                }
                else if (disc > 0)
                { 
                    Console.WriteLine("real and different roots ");
                    Console.WriteLine(solve1);
                    Console.WriteLine(solve2);
                }
                else if (disc == 0)
                {
                    Console.WriteLine("real and same roots");
                    Console.WriteLine(solve3);
                }
                else
                {
                    Console.WriteLine("Complea Roots");
                    Console.WriteLine($"{solve3} + i {root}");
                    Console.WriteLine($"{solve3} - i {root}");
                }
            }
            else
            {
                Console.WriteLine("list must be 3");
            }

        }
        
        static bool magic_square_checker(double[,] square)
        {
            double sums = 0;
            double root = Math.Sqrt(square.Length);

            for (int i = 0; i < root; i++)
            {
                sums = sums + square[i, i];
            }

            for (int i = 0; i < root; i++)
            {

                double row = 0;
                double colm = 0;

                for (int j = 0; j < root; j++)
                {
                    row += square[i, j];
                    colm += square[j, i];
                }
                if (row != colm || colm != sums)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Begin");
            Console.WriteLine(average(10, 15, 20));


            int[] prime_numbers = { 1, 3, 5, 7, 11, 13 };
            Console.WriteLine($"array of length = {prime_numbers.Length}");

            println(prime_numbers);

            prime_numbers[0] = 2;
            println(prime_numbers);


            double[] distances = { 3.1, 823.9, 12.8, 9.213, 72.5 };
            double a = avg(distances);
            Console.WriteLine($"avg = {a}");
            double[] w = { 1.1, 3.0, 5.2 };
            double[] o = {5.1, 3.6, 9.7}; // quadratic problem
            double[,] square1 = new double[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            
            double[][] square2 = new double[3][] 
            {
                new double[] { 1, 2, 3 },
                new double[] { 4, 5, 6 },
                new double[] { 7, 8, 9 }
            };

            print(w);

            double k = sum(distances);
            Console.WriteLine($"the sum is {k}");

            Console.WriteLine("---------------------------");
            quadratic(o);
            Console.WriteLine("---------------------------");

            pprint(square1);
            Console.WriteLine(magic_square_checker(square1));

            Console.WriteLine("---------------------------");
            pprint(square2);
            Console.WriteLine("---------------------------");

            Console.WriteLine("\nFinish");
        }
    }
}