namespace Tyuiu.GridinAE.Sprint2.Task1.V17.Test;
using Tyuiu.GridinAE.Sprint2.Task1.V17.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetLogicOperations()
    {
        var ds = new DataService();
        CollectionAssert.AreEqual
        (
            new bool[6] { true, false, true, true, true, false },
            ds.GetLogicOperations(135, 123, 455, 321)
        );
    }
}