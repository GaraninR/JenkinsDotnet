using NUnit.Framework;

namespace dotnet
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var box = new Box();
            Assert.IsTrue(box.getVolume() == 0);
        }

        [Test]
        public void Test2()
        {
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            Assert.IsTrue(1 == 0);
        }
    }
}