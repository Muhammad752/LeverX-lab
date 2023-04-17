using System.Reflection;

namespace Algorithms.Tests
{
    public class MethodsTests
    {
        private Methods _methodTest { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _methodTest = new Methods();
        }

        [Test]
        public void mult3and5_EqualTest()
        {
            //Asign
            var number = 10;

            //Act
            var sum=_methodTest.mult3and5(number);

            //Assert
            Assert.That(sum, Is.EqualTo(23));
        }

        [Test]
        public void numToStr_EqualTest()
        {
            var str = "Hello World!";
            var num=_methodTest.numToStr(str);
            Assert.That(num, Is.EqualTo("111211121311"));
        }

        [Test]
        public void uniqueInOrder_EqualTest()
        {
            var nord = new int[] { 1, 2, 2, 3, 3 };
            var res=_methodTest.UniqueInOrder(nord);
            Console.WriteLine(res);
            Assert.That(res, Is.EqualTo(new[] { 1,2,3}));
        }

        [Test]
        public void ips_between_EqualTest()
        {
            var sAddr = "10.0.0.0";
            var eAddr = "10.0.0.50";
            var diff=_methodTest.ips_between(sAddr, eAddr);
            Assert.That(diff, Is.EqualTo(50));
        }

        [Test]
        public void createSpiral_Test()
        {
            var num = 4;
            var res=_methodTest.createSpiral(num);
            Assert.That(res, Is.EqualTo(new[,] { { 1,2,3,4 }, { 12, 13, 14, 5 }, { 11, 16, 15, 6 }, { 10,9,8,7}}));
        }
    }
}