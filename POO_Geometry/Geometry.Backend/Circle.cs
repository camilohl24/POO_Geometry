
namespace Geometry.Backend;

public class Circle : GeometricFigure
{

    //Fields
    private double _r;

    // Constructors
    public Circle(string name, double r)
    {
        Name = name;
        R = r;
    }

    //Properties
    public double R 
    {
        get => _r;
        set => _r = ValidateR(value); 
    }

    //Methods

    private double ValidateR(double r)
    {
        if (double.IsNaN(r)||double.IsInfinity(r)||r <= 0 )
        {
            throw new ArgumentOutOfRangeException(nameof(r),$"Radius {r} must be greater than zero, real and positive");
        }
        return r;
    }
    public override double GetArea() => Math.PI * R *R;


    public override double GetPerimeter() => 2 * Math.PI * R ;
}
