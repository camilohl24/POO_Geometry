namespace Geometry.Backend;

public abstract class GeometricFigure
{
    //Properties
    public string Name { get; set; } = null!;

    //Methods
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString()=> $"{Name,-12} => Area.....:{GetArea(),15:F5}  Perimiter:{GetPerimeter(),15:F5}";
  
}


