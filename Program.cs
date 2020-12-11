using System;

namespace lb5_2
{
    class Cone
    {
        public double Radius { get; set; }
        public double Height { get; set; }


        public Cone(double R, double h)
        {
            Radius = R;
            Height = h;
        }

        public virtual double Volume()
        {
            return (Math.PI * Radius * Radius * Height) / 3;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Радиус основания R = " + Radius + "\n" + "Высота H = " + Height + "\n" + "Объем V = " + Volume() + "\n" + "Площадь основания S = " + Area() + "\n";
        }
    }

    class Frustum : Cone
    {
        public double radius { get; set; }

        public Frustum(double R, double h, double r) : base(R, h)
        {
            radius = r;
        }
        public override double Volume()
        {
            return (Math.PI * Height * (Radius * Radius + Radius * radius + radius * radius)) / 3;
        }
        public override string ToString()
        {
            return base.ToString() + "Радиус вершины r = " + radius + "\n";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Cone[] cones = new Cone[4];
            cones[0] = new Cone(6.4, 8.6);
            cones[1] = new Cone(4.2, 9.6);
            cones[2] = new Frustum(6.4, 7, 2.4);
            cones[3] = new Frustum(9.6, 4.2, 4.2);

            foreach (Cone c in cones)
            {
                Console.WriteLine(c.ToString());
            }
            Console.Read();
        }
    }
}
