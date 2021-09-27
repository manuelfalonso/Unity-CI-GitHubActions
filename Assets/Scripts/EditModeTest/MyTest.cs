using NUnit.Framework;

public class MyTest
{
    [Test]
    public void MyTestSimplePasses()
    {
        Assert.AreEqual(2 + 2, 4);
    }
}
