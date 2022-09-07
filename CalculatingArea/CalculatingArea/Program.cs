// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using CalculatingArea;

Calculating area = new();
int side1 = 8;
int side2 = 8;
int side3 = 8;
List<double> areatriangle = area.CalculatingTriangleThoughThreeSides(side1, side2, side3);
Console.WriteLine(areatriangle[1]);