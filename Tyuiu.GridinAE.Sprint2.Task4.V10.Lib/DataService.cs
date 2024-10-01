namespace Tyuiu.GridinAE.Sprint2.Task4.V10.Lib;

using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task4V10
{
    public double Calculate(double x, double y)
    {
        double z = 2 * x < y / 3 ? Math.Pow(1 + (3 / (y * y)), x) : y + 10 * x - 5 / x;
        return Math.Round(z, 3);
    }
}
