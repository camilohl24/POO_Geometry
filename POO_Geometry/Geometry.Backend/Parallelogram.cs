
namespace Geometry.Backend;

public class Parallelogram : Rectangle
{
    private double _h;
    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }

    public double H
    {
        get => _h;
        set => _h =ValidateH(value);
    }
    public override double GetArea() => B * H;


    public override double GetPerimeter() => 2 * (A + B);

    private double ValidateH(double h)
    {
        if (double.IsNaN(h) || double.IsInfinity(h) || h <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(h), $"height {h} must be greater than zero, positive and real number.");
        }
        return h;
    }
}
