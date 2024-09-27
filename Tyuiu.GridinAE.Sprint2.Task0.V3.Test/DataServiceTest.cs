namespace Tyuiu.GridinAE.Sprint2.Task0.V3.Test;
using Tyuiu.GridinAE.Sprint2.Task0.V3.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetCompareOperations()
    {
        DataService ds = new DataService();
        int x = 45;
        int y = 127;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);
        bool[] wait = new bool[6] { false, true, false, true, false, true };
        
        CollectionAssert.AreEqual(res, wait);
    }
}