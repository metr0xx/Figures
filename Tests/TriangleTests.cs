using Figures;
using NUnit.Framework;

namespace tests;

public class FigureTests
{
    [Test]
    public void NonExistentTriangle()
    {
        try
        {
            IFigure triangle = new Triangle(3, 3, 8);
        }
        catch (Exception e)
        {
            StringAssert.Contains(e.Message, "Треугольнка с такими сторонами не существует");
            return;
        }

        Assert.Fail("Ожидаемое исключение не было вызвано");
    }
    
    [Test]
    public void SideIsNotPositive()
    {
        try
        {
            IFigure triangle = new Triangle(-1, 1, 1);
        }
        catch (Exception e)
        {
            StringAssert.Contains(e.Message, "Стороны должны быть больше нуля");
            return;
        }

        Assert.Fail("Ожидаемое исключение не было вызвано");
    }
    
    [Test]
    public void RightTriangle()
    {
        IFigure triangle = new Triangle(3, 4, 5);
        Assert.AreEqual(6.0, triangle.CalcArea(), 1e-3, "Ожидаемое значение не совпало с результатом");
    }
    
    [Test]
    public void CommonTriangle()
    {
        IFigure triangle = new Triangle(13, 14, 15);
        Assert.AreEqual(84.0, triangle.CalcArea(), 0.1, "Ожидаемое значение не совпало с результатом");
    }
}