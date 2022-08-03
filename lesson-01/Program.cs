
namespace lesson_01
{
    internal class Program
    {
        static void variables()
        {
            sbyte bite = 127;          // -128..127


            // negative and positive
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


            // positive
            byte chips = 255;
            ushort tail = 65_535;  // 0..2^16 - 1
            uint ger = 4294967295;  // 0..2^32 - 1     
            ulong life = 18_446_744_073_709_551_615; // 0..2^63-1

        }

        static void chars()
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
        }

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
            Console.WriteLine(" ]");
        }

        static double sum(double[] list)
        {
            double summary = 0.0;
            for (int i = 0; i < list.Length; i++)
            {
                summary += list[i];
            }
            return summary;
        }

        static void println(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"{list[i]}, ");
            }
            Console.WriteLine();
        }

        static double avg(double[] lst)
        {
            double sum = 0.0;
            for (int i = 0; i < lst.Length; i++)
            {
                sum += lst[i];
            }

            return sum / lst.Length;
        }
        static double quadratic(double[] list)
        {
            if list.Length < 4
            {
                double disc = list[1] * list[1] - 4 * list[0] * list[2];
                double 
            }
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

            print(w);
            double k = sum(distances);
            Console.WriteLine($"the sum is {k}");

            Console.WriteLine("Finish");
        }
    }
}