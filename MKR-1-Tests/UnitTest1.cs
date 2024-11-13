namespace MKR_1;

public class UnitTest1
{
    private LuckyNumbersTask _task;
    
    [SetUp]
    public void Setup()
    {
        _task = new LuckyNumbersTask();
    }

    [Test]
    public void TestDefaultValue()
    {
        var res = _task.Handle(56);

        Assert.AreEqual(res, 4);
    }
    
    [Test]
    public void TestValidation()
    {
        Assert.Throws<ArgumentException>(code: (() => _task.Handle(3000000)));
    }
    
    [Test]
    public void TestDefaultValue100()
    {
        var res = _task.Handle(100);

        Assert.AreEqual(res, 6);
    }
    
    [Test]
    public void TestDefaultValue4()
    {
        var res = _task.Handle(4);

        Assert.AreEqual(res, 1);
    }
    
    [Test]
    public void TestDefaultValue1032()
    {
        var res = _task.Handle(1032);

        Assert.AreEqual(res, 14);
    }
}