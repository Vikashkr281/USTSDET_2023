namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Init()
        {
            Console.WriteLine("Setup method");
           
        }
        [Test]
        public void Test2()
        {
            Assert.AreNotEqual(1, 51);
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("test1");
            Assert.AreEqual(1, 1);
        }
        [TearDown]
        public void Close()
        {
            Console.WriteLine("Close method");
        }
    }
}