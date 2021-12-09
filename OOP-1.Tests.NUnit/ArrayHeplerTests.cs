using NUnit.Framework;

namespace OOP_1.Tests.NUnit
{
    public class ArrayHelperTests
    {
       

        [Test]
        public void Numelemetodeipecareotestam_WhenAnumiteconditii_ThanSeintamplaceva()
        {
            int[] Vector1 = { 1 , 2 };
            int frequencies = ArrayHelper.Identitate(Vector1);
            Assert.AreEqual( 3 , 2 , frequencies );
        }
    }
}