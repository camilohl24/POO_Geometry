namespace Geometry.Backend
{
    public class Square : GeometricFigure
    {
        private double _a;

        public Square(string name,double a)
        {
            Name = name;
            A = a;
        }

        public double A
        { 
            get => _a; 
            set => _a =ValidateA(value); 
        }

        public override double GetArea()=> A*A;
       

        public override double GetPerimeter() => 4 * A;
        private double ValidateA(double a)
        {
            if (double.IsNaN(a)||double.IsInfinity(a)||a <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Side {a} must be greater than zero,real and positive.");
            }
            return a;
        }
    }
}
