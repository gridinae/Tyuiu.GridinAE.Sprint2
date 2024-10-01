namespace Tyuiu.GridinAE.Sprint2.Task6.V4.Test;
using Tyuiu.GridinAE.Sprint2.Task6.V4.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidFindCardSuit()
    {
        DataService dataService = new DataService();
        Assert.AreEqual("����", dataService.FindCardSuit(1));
        Assert.AreEqual("�����", dataService.FindCardSuit(2));
        Assert.AreEqual("�����", dataService.FindCardSuit(3));
        Assert.AreEqual("�����", dataService.FindCardSuit(4));
    }
}