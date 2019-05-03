using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public static partial class Lesson
    {

        public static void AbstractionShapeExample()
        {
            IShape[] shapes = new IShape[]
            {
                new Rectangle(10, 10),
                new Circle(5),
                new Circle(12)
            };

            Print(shapes);
        }

        public static void Print(params IShape[] shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }

    }

    public interface IShape
    {
        int Draw();
    }

    class Rectangle : IShape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Draw()
        {
            return (int)width*height;
        }
    }


    public class Circle : IShape
    {
        private int rad;

        public Circle(int rad)
        {
            this.rad = rad;
        }

        public int Draw()
        {
			return (int)Math.PI*rad*rad;
		}
    }


    public class Triangle : IShape
    {
        private int a;
        private int b;
        private int c;
        private int s;

		public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.a = c;
            s = ( (a + b + c)/2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c));

        }

        public int Draw()
        {
			return (int)Math.Sqrt((double)s);
		}
    }

}
