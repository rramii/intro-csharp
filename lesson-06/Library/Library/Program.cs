namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var jk = new Person("JK", "Roling", "001", "jk@azbakan.net");
            var authors = new List<Person>() { jk };
            var harry = new Book("Harry Potter and the fire stone", "1337", authors, 4);

            var c = new Catalog();
            c.Add(harry);
            
            c.Add(new Book("Jedi Secret Manual", "0007",
                new List<Person>() { 
                    new Person("Master", "Yoda", "11111", "y@sky.net"),
                    new Person("Obi", "Wan", "22222", "obi@sky.net")
                }
                , 1));


            c.Add(new Book("How to Kill a Jedi ", "66666S",
                new List<Person>() {
                    new Person("Sedious", "Lord", "6666666", "y@sith.net")                 
                }
                , 1));

            c.Add(new Book("Da Vinci Code", "0008",
                new List<Person>() {
                    new Person("Dan", "Brown", "6666", "dan@books.net")                    
                }
                , 10));


            Console.WriteLine(c.Count);
            Console.WriteLine("----------------------------");
            var result = c.FindByIsbn("0007");
            if (result.Item1)
            {
                Console.WriteLine(result.Item2);
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            Console.WriteLine("----------------------------");
            var (found, book) = c.FindByIsbn("0013");
            if (found)
            {
                Console.WriteLine(book);
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            Console.WriteLine("----------------------------");

            var title = "Jedi Secret Manual";
            var lst = c.FindByTitle(title);
            Console.WriteLine($"found {lst.Count} books with title {title}");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");

            var idk = c.FindByAurthor
            lst = c.FindByTitleContains("Jedi");
            Console.WriteLine($"found {lst.Count} books containing Jedi");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            /*var notFound = c.FindByIsbn("0777");
            Console.WriteLine(notFound);*/

        }
    }
}