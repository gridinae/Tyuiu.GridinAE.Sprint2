namespace Tyuiu.GridinAE.Sprint2.Task3.V10.Test;
using Tyuiu.GridinAE.Sprint2.Task3.V10.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()
    {
        DataService dataService = new DataService();
        Assert.AreEqual(-70.25, dataService.Calculate(2));
        Assert.AreEqual(-1, dataService.Calculate(0));
        Assert.AreEqual(0.167, dataService.Calculate(-1));
        Assert.AreEqual(-1099.99, dataService.Calculate(-100));
    }
}