using NUnit.Framework;

namespace br.com.badr.etd
{
    public class AppTest {
        [SetUp]
        public void setup() {
            Console.WriteLine("setup");
        }

        [Test]
        public void test() {
            Console.WriteLine("Teste Ok");
            Assert.Pass();
        }
    }
}