namespace CalculatingArea;

public class Calculating
{
    public double CalculatingCircleThoughRadius (double radius)
    {
        double area = 3.14 * (radius * radius);
        return area;
    }
    
    public double CalculatingCircleThoughDiametr (double diametr)
    {
        double area = (3.14 * (diametr * diametr))/4;
        return area;
    }

    public List<double> CalculatingTriangleThoughThreeSides(int side1, int side2, int side3)
    {
        List<double> results = new List<double>();

    double area;
        double checkrectangular = CheckRectangularTriangle(side1, side2, side3);
        double checkIsosceles = CheckIsosceles(side1, side2, side3);
        double checkEquilaterall = checkEquilateral(side1, side2, side3);
        if (!(checkrectangular == 0))
        {
            Console.WriteLine("Прямоугольный треугольник");
            results.Add(1);
            area = checkrectangular;
            results.Add(area);
        }
        else if(!(checkIsosceles == 0))
        {
            Console.WriteLine("Равнобедренный треугольник");
            results.Add(2);
            area = checkIsosceles;
            results.Add(area);
        }
        else if(!(checkEquilaterall==0))
        {
            Console.WriteLine("Равносторонний треугольник");
            results.Add(3);
            area = checkEquilaterall;
            results.Add(area);
        }
        else
        {
            int polyperimetr = (side1 + side2 + side3)/2;
            results.Add(4);
            area = Math.Sqrt(polyperimetr * (polyperimetr - side1) * (polyperimetr - side2) * (polyperimetr - side3));
            results.Add(area);
        }

        return results;
    }
    

    public double CalculatingAreaThoughHeightAndOneSides(double Height, double Side)
    {
        double area = (Height * Side) / 2;
        return area;
    }

    private double CheckRectangularTriangle(int side1, int side2, int side3)
    {
        double area;
        if (side1 * side1 == side2 * side2 + side3 * side3)
        {
            area = (side2 * side3) / 2;
        }
        else if(side2*side2 == side1 * side1 + side3 * side3)
        {
            area = (side1 * side3) / 2;
        }
        else if(side3*side3 == side1 * side1 + side2 * side2)
        {
            area = (side1 * side2) / 2;
        }
        else
        {
            area = 0;
        }
        return area;
    }

    private double CheckIsosceles(double a, double b, double c)
    {
        double area;
        if (a == b && (!(a==c)) )
        {
            area = (c/4) *(Math.Sqrt(4*(a*a) - (c*c)));
        }
        else if(a == c && (!(a==b)))
        {
            area = (b/4) *(Math.Sqrt(4*(a*a)- (b*b)));
        }
        else if(b == c && (!(b==a)))
        {
            area = (a/4) *(Math.Sqrt(4*(b*b) - (a*a)));
        }
        else
        {
            area = 0;
        }
        return area;
    }

    private double checkEquilateral(int a, int b, int c)
    {
        double area;
        if (a == b && b == c)
        {
            area = (Math.Sqrt(3) * (a * a)) / 4;
        }
        else
        {
            area = 0;
        }
        return area;
    }
}