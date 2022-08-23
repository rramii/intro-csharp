namespace Shapes
{
    
    internal class Program
    {
        static void PaintPrice(AbstractShape shape)
        {
            var priceForLiter = 1337.0;
            //var surface = shape.Area();
            //var vol = surface * 1e-4;
            //var price = vol * priceForLiter;
            //Console.WriteLine($"paint {shape.Name} will cost {price}");

            Console.WriteLine($"paint {shape.Name} will cost {shape.PaintVolume(0.01) * priceForLiter}");
        }

        static void Paint(List<AbstractShape> lst)
        {
            foreach (var shape in lst)
            {
                PaintPrice(shape);
            }
        }
        static void Main(string[] args)
        {           
            var s = new Square(4);
            PaintPrice(s);

            var c = new Circle(4);
            PaintPrice(c);

            Console.WriteLine("-------------------------");
            var shapes = new List<AbstractShape>() { new Circle(3), new Square(4), new Circle(5) };
            Paint(shapes);
        }
    }
}