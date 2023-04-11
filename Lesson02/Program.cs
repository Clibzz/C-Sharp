namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10.0, 20.0);
            double area = rect.GetArea();
            // {0} contains the value of area
            Console.WriteLine("The area of the rectangle: {0}", area);
        }
    }

    class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double l, double w)
        {
            this.length = l;
            this.width = w;
        }   

        public double GetArea()
        {
            return length * width;
        }
    }
}

