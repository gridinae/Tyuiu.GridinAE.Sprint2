using Tyuiu.GridinAE.Sprint2.Task4.V10.Lib;

namespace Tyuiu.GridinAE.Sprint2.Task4.V10.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()
    {
        DataService dataService = new DataService();
        Assert.AreEqual(1.037, dataService.Calculate(1, 9));
        Assert.AreEqual(20.5, dataService.Calculate(2, 3));
    }
}