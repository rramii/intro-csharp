namespace lesson_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sl = new SortedList();
            Fill(sl, 10);
            Print(sl);

            var x = new int[] { 1, 2, 3, 4 }; 
        }

        private static void Print(SortedList sl)
        {
            Console.Write("{" + $"{sl.Get(0)}");
            for (int i = 1; i < sl.Count(); i++)
            {
                Console.Write($", {sl.Get(i)}");
            }
            Console.Write("}");
        }

        private static void Fill(SortedList sl, int n)
        {
            var rng = new Random();
            for (int i = 0; i < n; i++)
            {
                sl.Add(rng.Next(1, 20));
            }
        }
    }
}