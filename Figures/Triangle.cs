namespace Figures;

public class Triangle : IFigure
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;
    public Triangle(double a, double b, double c)
    {
        if(a <= 0 || b <= 0 || c <= 0) throw new Exception("Стороны должны быть больше нуля");
        if (a + b <= c || a + c <= b || c + b <= a) throw new Exception("Треугольнка с такими сторонами не существует");
        _a = a;
        _b = b;
        _c = c;
    }
    public double CalcArea()
    {
        var list = new List<double> { _a, _b, _c };
        list.Sort();
        var hip2 = Math.Pow(list[0], 2) + Math.Pow(list[1], 2);
        if(Math.Abs(hip2 - Math.Pow(list[2], 2)) < 1e-12) return list[0] * list[1] / 2;
        var p = list.Sum() / 2;
        return Math.Sqrt(p * (p - list[0]) * (p - list[1]) * (p - list[2]));
    }
}