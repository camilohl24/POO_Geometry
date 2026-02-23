namespace Geometry.Backend;

public abstract class GeometricFigure
{
    //Properties
    public string Name { get; set; } = null!;

    //Methods
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString()=> $"{Name,-15} => Area.....:{GetArea(),15:N5}  Perimiter:{GetPerimeter(),15:N5}";
  
}


