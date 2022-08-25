﻿namespace Shapes
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

        static void dictionarybuilder(List<AbstractShape> lst)
        {
            Dictionary<string, List<AbstractShape>> _list = new Dictionary<string, List<AbstractShape>>();
            List<AbstractShape> list = lst;
            foreach (var shape in lst)
            {
                if (shape.Name == "Circle")
                {
                    _list.Add(shape.Name, list.Add(shape));
                }
                else if (shape.Name == "square")
                {

                }
            }
        }

        static void Main(string[] args)
        {           
            var sq = new Square(4);
            PaintPrice(sq);

            var c = new Circle(4);
            PaintPrice(c);

            var r = new Ring(1.2, 4);
            PaintPrice(r);

            var sp = new Sphere(4);
            PaintPrice(sp);
            Console.WriteLine("-------------------------");
            var shapes = new List<AbstractShape>() { new Circle(3), new Square(4), new Circle(5) };
            Paint(shapes);
            dictionarybuilder(shapes);
        }
    }
}