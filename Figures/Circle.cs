namespace Figures;

public class Circle : IFigure
{
    private readonly double _radius;
    
    public Circle(double radius)
    {
        if(radius <= 0) throw new Exception("Радиус должен быть больше нуля");   
        _radius = radius;
    }
    
    public double CalcArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}