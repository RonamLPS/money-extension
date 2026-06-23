namespace MoneyExtension.Tests;

[TestClass]
public sealed class MoneyExtensionTests
{
    [TestMethod]
    public void DeveConverterDecimalParaInteiro()
    {
        decimal valor = 1213.45m;
        int cents = valor.ToCents();

        Assert.AreEqual(121345, cents);
    }
}