using CalculatingArea;


namespace TestCalculatingArea;

public class Tests
{
    //первый элемент листа - тип треугольника, второй значение площади
    //1-прямоугольный треугольник
    //2-равнобедренный треугольник
    //3-равносторонний треугольник
    //4-обычный трейгольник
    [Test]
    public void TestCalculatingTriangleThoughThreeSides()
    {
        Calculating area = new();
        int side1 = 8;
        int side2 = 7;
        int side3 = 5;
        List<double> areatriangle = area.CalculatingTriangleThoughThreeSides(side1, side2, side3);
        Assert.AreEqual(17.321,Math.Round(areatriangle[1],3));
    }
    [Test]
    public void TestCalculatingAreaThoughHeightAndOneSides()
    {
        Calculating area = new();
        double side1 = 15;
        double height = 5;
        double areatriangle = area.CalculatingAreaThoughHeightAndOneSides(side1, height);
        Assert.AreEqual(37.5,Math.Round(areatriangle,1));
    }
    [Test]
    public void TestCalculatingCircleThoughRadius()
    {
        Calculating area = new();
        double radius = 15;
        double areatriangle = area.CalculatingCircleThoughRadius(radius);
        Assert.AreEqual(706.5,areatriangle);
    }
    [Test]
    public void TestCalculatingCircleThoughDiametr()
    {
        Calculating area = new();
        double diametr = 10;
        double areatriangle = area.CalculatingCircleThoughDiametr(diametr);
        Assert.AreEqual(78.5,areatriangle);
    }
    
    [Test]
    public void TestCheckIsosceles()
    {
        Calculating area = new();
        int side1 = 5;
        int side2 = 5;
        int side3 = 7;
        List<double> areatriangle = area.CalculatingTriangleThoughThreeSides(side1, side2, side3);
        Assert.AreEqual(12.4975,Math.Round(areatriangle[1],4));
        Assert.AreEqual(2,areatriangle[0]);

    }
    
    [Test]
    public void TestcheckEquilateral()
    {
        Calculating area = new();
        int side1 = 8;
        int side2 = 8;
        int side3 = 8;
        List<double> areatriangle = area.CalculatingTriangleThoughThreeSides(side1, side2, side3);
        Assert.AreEqual(27.71281,Math.Round(areatriangle[1],5));
        Assert.AreEqual(3,areatriangle[0]);

    }
    
}