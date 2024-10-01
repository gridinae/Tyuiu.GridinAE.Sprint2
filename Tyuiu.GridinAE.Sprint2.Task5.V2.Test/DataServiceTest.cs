namespace Tyuiu.GridinAE.Sprint2.Task5.V2.Test;
using Tyuiu.GridinAE.Sprint2.Task5.V2.Lib;
[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidFindMonthSeason()
    {
        DataService dataService = new DataService();
        Assert.AreEqual("Зима", dataService.FindMonthSeason(12));
        Assert.AreEqual("Весна", dataService.FindMonthSeason(3));
        Assert.AreEqual("Осень", dataService.FindMonthSeason(9));
        Assert.AreEqual("Лето", dataService.FindMonthSeason(6));
    }
}