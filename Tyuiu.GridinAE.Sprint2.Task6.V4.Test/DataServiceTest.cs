namespace Tyuiu.GridinAE.Sprint2.Task6.V4.Test;
using Tyuiu.GridinAE.Sprint2.Task6.V4.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidFindCardSuit()
    {
        DataService dataService = new DataService();
        Assert.AreEqual("пики", dataService.FindCardSuit(1));
        Assert.AreEqual("трефы", dataService.FindCardSuit(2));
        Assert.AreEqual("бубны", dataService.FindCardSuit(3));
        Assert.AreEqual("червы", dataService.FindCardSuit(4));
    }
}