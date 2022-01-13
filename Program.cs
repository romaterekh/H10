using System;
using System.Collections.Generic;

namespace H10
{
    public struct Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"({x},{y})";
        }
    }

    public class Triangle
    {
        private Point p1, p2, p3;
        public Triangle(Point a, Point b, Point c)
        {
            p1 = a;
            p2 = b;
            p3 = c;
        }

        public double Distance(Point point1, Point point2)
        {
            return Math.Sqrt((point2.x - point1.x) * (point2.x - point1.x) + (point2.y - point1.y) * (point2.y - point1.y));
        }

        public double Perimeter()
        {
            return Distance(p1, p2) + Distance(p2, p3) + Distance(p3, p1); 
        }

        public double Area()
        {
            double p = (Distance(p1, p2) + Distance(p2, p3) + Distance(p3, p1)) / 2;
            double area = Math.Sqrt(p * (p - Distance(p1, p2)) * (p - Distance(p2, p3)) * (p - Distance(p3, p1)));
            return area;
        }

        public void Print()
        {
            Console.WriteLine($"Sides ab={Distance(p1, p2)} bc={Distance(p2, p3)} ca={Distance(p3, p1)}");
            Console.WriteLine($"Perimeter={Perimeter()} Area={Area()}");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Enter Point1");
                int a1 = Convert.ToInt32(Console.ReadLine());
                int a2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Point2");
                int b1 = Convert.ToInt32(Console.ReadLine());
                int b2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Point3");
                int c1 = Convert.ToInt32(Console.ReadLine());
                int c2 = Convert.ToInt32(Console.ReadLine());
                triangles.Add(new Triangle(new Point(a1, a2), new Point(b1, b2), new Point(c1, c2)));
            }
            foreach (Triangle triangle in triangles)
            {
                Console.WriteLine("");
                triangle.Print();
            }
        }
    }
}