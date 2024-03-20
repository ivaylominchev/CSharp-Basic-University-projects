namespace _02._Figures
{
    class Figure  
    {
        public virtual float getSize()      
        {
            return -1;      
        }
        public virtual void setMeasures()    
        { 

        }

        class Circle : Figure
        {
            private float radius;   
            public override void setMeasures()  
            {
                do
                {
                    Console.Write("Enter radius of the circle: ");
                    radius = float.Parse(Console.ReadLine());
                } while (radius < 0);
            }
            public override float getSize()     
            {
                float p = (float)Math.PI;
                float size = (float)Math.Pow(radius, 2) * p;
                return size;
            }
        }

        class Trapezoid : Figure
        {
            public float a; 
            public float b; 
            public float h; 

            public override void setMeasures()
            {
                do
                {
                    Console.Write("Enter base a: ");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("Enter base b: ");
                    b = float.Parse(Console.ReadLine());
                    Console.Write("Enter height h: ");
                    h = float.Parse(Console.ReadLine());
                } while ((a < 0) && (b < 0) && (h < 0));
            }
            public override float getSize()
            {
                float size = h * (a + b) / 2;
                return size;
            }
        }

        class Square : Figure
        {
            public float a; 
            public override void setMeasures()
            {
                do
                {
                    Console.Write("Enter a side of the square: ");
                    a = float.Parse(Console.ReadLine());
                } while (a < 0);
            }
            public override float getSize()
            {
                float size = a * a;
                return size;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Figure[] Parts = new Figure[3];  

                int n;
                double area = 0;

                for (int i = 0; i < Parts.Length; i++)
                {
                    do
                    {
                        Console.WriteLine("Enter 1 - for circle, 2 - for trapezoid, 3 - for square: ");


                        n = int.Parse(Console.ReadLine());
                    }
                    while (n < 1 || n > 3);
                    switch (n)
                    {
                        case 1:
                            Parts[i] = new Circle();
                            Parts[i].setMeasures();
                            break;
                        case 2:
                            Parts[i] = new Trapezoid();
                            Parts[i].setMeasures();
                            break;
                        case 3:
                            Parts[i] = new Square();
                            Parts[i].setMeasures();
                            break;
                    }
                }

                foreach (Figure f in Parts)
                {
                    area += f.getSize();  
                }
                Console.WriteLine($"The total area of the figures is: {area:F2}");
            }
        }
    }
}
