using Figures;
using NUnit.Framework;

namespace tests;

public class CircleTests
{
    [Test]
    public void RadiusIsNotPositive()
    {
        try
        {
            IFigure circle = new Circle(0);
        }
        catch (Exception e)
        {
            StringAssert.Contains(e.Message, "Радиус должен быть больше нуля");
            return;
        }
        
        Assert.Fail("Ожидаемое исключение не было вызвано");
    }
    
    [Test]
    public void CommonCircle()
    {
        IFigure circle = new Circle(2);
        Assert.AreEqual(12.56, circle.CalcArea(), 0.1, "Ожидаемое значение не совпало с результатом");
    }
}