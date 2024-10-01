namespace Tyuiu.GridinAE.Sprint2.Task5.V2.Test;
using Tyuiu.GridinAE.Sprint2.Task5.V2.Lib;
[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidFindMonthSeason()
    {
        DataService dataService = new DataService();
        Assert.AreEqual("зима", dataService.FindMonthSeason(12));
        Assert.AreEqual("весна", dataService.FindMonthSeason(3));
        Assert.AreEqual("осень", dataService.FindMonthSeason(9));
        Assert.AreEqual("лето", dataService.FindMonthSeason(6));
    }
}