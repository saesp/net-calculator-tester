using net_calculator_tester;

namespace net_calculator_testerTest
{
    //Creare in seguito una classe di test che abbia 4 metodi, ognuno per verificare il corretto funzionamento di ogni metodo presente nella classe Calculator.
    public class Tests
    {
        [Test]
        public void AddTest()
        {
            Assert.IsTrue(Calculator.Add(2, 3) == 5);
        }

        [TestCase (6, 3, 3)]
        [TestCase(10, 5, 5)]
        [TestCase(3, 3, 1)]
        public void SubtractTest(float a, float b, float result)
        {
            Assert.IsTrue(Calculator.Subtract(a, b) == result);

        }

        [Test]
        public void MultiplyTest()
        {
            Assert.IsTrue(Calculator.Multiply(3, 3) == 9);

        }

        [Test]
        public void DivideTest()
        {
            Assert.IsTrue(Calculator.Divide(10, 2) == 5);

        }
    }
}