

namespace Geometry.Backend;

public class Rhombus:Square
{
    //Fields
    private double _d1;
    private double _d2;

    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }

    public double D1
    {
        get => _d1;
        set => _d1 = ValidateD1(value);
    }
    public double D2
    {
        get => _d2; 
        set => _d2 = ValidateD2(value);
    }
    public override double GetArea() => (D1 * D2)/2;


    public override double GetPerimeter() => 4 * A;
    private double ValidateD1(double d1)
    {
        if (double.IsNaN(d1) || double.IsInfinity(d1) || d1 <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(d1), $"Diagonal {d1} must be greater than zero, positive and real number.");
        }
        return d1;
    }
    private double ValidateD2(double d2)
    {
        if (double.IsNaN(d2) || double.IsInfinity(d2) || d2 <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(d2), $"Diagonal {d2} must be greater than zero, positive and real number.");
        }
        return d2;
    }
}
