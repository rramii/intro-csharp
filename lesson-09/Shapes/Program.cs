namespace Shapes
{

    internal class Program
    {
        static double PaintPrice(AbstractShape shape, double thickness = 0.01)
        {
            var priceForLiter = 1337.0;
            //var surface = shape.Area();
            //var vol = surface * 1e-4;
            //var price = vol * priceForLiter;
            //Console.WriteLine($"paint {shape.Name} will cost {price}");

            var volume = shape.Area() * thickness;
            var cost = volume * priceForLiter;
            Console.WriteLine($"paint {shape.Name}--{shape.Dimensions} will cost {cost}");
            return cost;
        }

        static double Paint(List<AbstractShape> lst)
        {
            double total = 0;
            foreach (var shape in lst)
            {
                total += PaintPrice(shape);
            }
            return total;
        }

        static Dictionary<string, List<AbstractShape>> dictionarybuilder(List<AbstractShape> shapes)
        {
            var dict = new Dictionary<string, List<AbstractShape>>();
                        
            foreach (var shape in shapes)
            {
                var key = shape.Name;
                if( dict.ContainsKey(key))
                {
                    dict[key].Add(shape);
                }
                else
                {
                    var list = new List<AbstractShape>() { shape };
                    dict.Add(key, list);
                }
            }

            return dict; 
        }

        static void Main(string[] args)
        {           
            var sq = new Square(4);
            PaintPrice(sq);

            var c = new Circle(4);
            PaintPrice(c);

            var r = new Ring(2.6, 4);
            PaintPrice(r);

            var sp = new Sphere(4);
            PaintPrice(sp);
            Console.WriteLine("-------------------------");
            var shapes = new List<AbstractShape>() { 
                new Circle(3), new Square(4), new Circle(5), new Circle(3), new Ring(5, 6) 
            };

            Paint(shapes);

            Console.WriteLine("-------------------------");
            var dict = dictionarybuilder(shapes);

            Paint(dict["Circle"]);
        }
    }
}