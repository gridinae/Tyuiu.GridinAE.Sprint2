namespace Tyuiu.GridinAE.Sprint2.Task2.V30.Test;
using Tyuiu.GridinAE.Sprint2.Task2.V30.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCheckDotInShadedArea()
    {
        DataService dataService = new DataService();
        Assert.AreEqual(true, dataService.CheckDotInShadedArea(12, 7));
        Assert.AreEqual(true, dataService.CheckDotInShadedArea(6, 9));
        Assert.AreEqual(false, dataService.CheckDotInShadedArea(2, 3));
        Assert.AreEqual(false, dataService.CheckDotInShadedArea(8, 8));

    }
}