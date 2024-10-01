namespace Tyuiu.GridinAE.Sprint2.Task1.V17.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task1V17
{
    public bool[] GetLogicOperations(int a, int b, int c, int d)
    {
        return new bool[6]
        {
            a == b | c > d,
            b <= d & a < c - d,
            b != c || a + b == c,
            d + 134 == c && a >= b,
            !(c < b),
            c < d ^ c < b
        };
    }
}
