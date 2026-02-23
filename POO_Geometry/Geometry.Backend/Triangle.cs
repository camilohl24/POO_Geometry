namespace Geometry.Backend;

public class Triangle : Rectangle
{
    private double _c;
    private double _h;

    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        C = c;
        H = h;
    }

    public double C
    { 
        get => _c;
        set => _c = ValidateC(value); 
    }
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    public override double GetArea() => (B * H)/2;


    public override double GetPerimeter() => A + B + C;

    private double ValidateH(double h)
    {
        if (double.IsNaN(h) || double.IsInfinity(h) || h <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(h), $"height {h} must be greater than zero, positive and real number.");
        }
        return h;
    }
    private double ValidateC(double c)
    {
        if (double.IsNaN(c) || double.IsInfinity(c) || c <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(c), $"height {c} must be greater than zero, positive and real number.");
        }
        return c;
    }
}


