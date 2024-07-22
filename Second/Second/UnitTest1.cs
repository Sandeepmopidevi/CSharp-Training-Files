using First;
using NUnit.Framework.Legacy;

namespace Second
{
    [TestFixture]
    public class Tests
    {
        public int a = 67;
        public int b = 45;

        [Test]
        public void testsum()
        {
            Sample s1 = new Sample();
            ClassicAssert.AreEqual(112, s1.sum(a, b));
        }
    }
}
