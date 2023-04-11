namespace Lesson02 {
    class Program {
        static void Main(string[] args) {
            Rectangle rect = new Rectangle();
            rect.Length = 10.0;
            rect.Width = 20.0;
            double area = rect.GetArea();
            // {0} contains the value of area
            Console.WriteLine("The area of the rectangle: {0}", area);
        }
    }

    class Rectangle {
        private double length;
        private double width;
        public double Length {
            get {
                return this.length;
            }
            set {
                if (value > 0.0) {
                    this.length = value;
                }
            }
        }

        public double Width {
            get {
                return this.width;
            }
            set {
                if (value > 0.0) {
                    this.width = value;
                }
            }
        }

        public double GetArea() {
            return this.length * this.width;
        }
    }
}

