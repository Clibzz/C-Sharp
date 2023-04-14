namespace Lesson02 {
    class Program {
        static void Main(string[] args) {
            Rectangle r = new Rectangle();
            r.Changed += new EventHandler(r_Changed);
            r.Length = 20;
        }
        static void r_Changed(object sender, EventArgs e) {
            Rectangle r = (Rectangle)sender;
            Console.WriteLine(
                "Value Changed: Length = {0}",
                r.Length);
        }
    }

    class Rectangle {
        public event EventHandler Changed;
        private double length;
        public double Length {
            get {
                return this.length;
            }
            set {
                this.length = value;
                Changed(this, EventArgs.Empty);
            }
        }
    }
}

