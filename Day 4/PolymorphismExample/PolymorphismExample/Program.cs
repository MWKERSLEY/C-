using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Polygon> polygons = new List<Polygon>();
            polygons.Add(new Polygon());
            polygons.Add(new Rectangle());
            polygons.Add(new Triangle());
            foreach (Polygon p in polygons)
            {
                p.Draw();
            }
            Triangle triangle1 = new Triangle();
            triangle1.Draw();
        }
    }

    class Polygon
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a polygon");
        }
    }
    class Rectangle:Polygon
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
    class Triangle:Polygon
    {
        public new void Draw()
        {
            Console.WriteLine("Drawing a triangle");
        }
    }
}
