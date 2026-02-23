

namespace Geometry.Backend;

public class Kite : Rhombus
{
    private double _b;

    public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
    {
        B = b;
    }

    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }
    public override double GetArea() => (D1 * D2) / 2;


    public override double GetPerimeter() => 2 * (A + B);

    private double ValidateB(double b)
    {
        if (double.IsNaN(b) || double.IsInfinity(b) || b <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(b), $"Side {b} must be greater than zero, positive and real number.");
        }
        return b;
    }
}
