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
            Console.WriteLine(x[3]);
            Console.WriteLine(sl.Get(4));


        }

        private static void Print(SortedList sl)
        {
            List<int> new_list = new List<int>();
            for (int i = 0; i < sl.Count(); i++)
            {
                new_list.Append(i);
            }
            SortedList.Sorting(new_list);
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