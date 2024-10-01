namespace Tyuiu.GridinAE.Sprint2.Task6.V4.Lib;
using tyuiu.cources.programming.interfaces.Sprint2;

public class DataService : ISprint2Task6V4
{
    public string FindCardSuit(int value) => value switch
    {
        1 => "пики",
        2 => "трефы",
        3 => "бубны",
        4 => "червы",
        _ => String.Empty
    };
}
