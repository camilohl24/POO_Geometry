using Geometry.Backend;

var circle = new Circle(nameof(Circle),5);
var square = new Square(nameof(Square),10);
var rhombus = new Rhombus(nameof(Rhombus), 5,7,10);

var figures = new List<GeometricFigure>(){ circle, square,rhombus };
foreach (var figure in figures)
{
    Console.WriteLine(figure);
}