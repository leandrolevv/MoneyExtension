namespace MoneyExtension.test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void ShouldConvertMoneyInCents()
    {
        var amount = 1234.56M;
        var result = amount.ToCents();

        Assert.AreEqual(123456, result);
    }
}