using NUnit.Framework;
using System;


namespace PragmaticUnitTesting
{
    [TestFixture]
    public class LargestTest
    {
        [SetUp]
        public void PerTestSetUp()
        {

        }

        [TearDown]
        public void PerTestTearDown()
        {

        }

        [Category("Short")]
        public void LargestOf3()
        {
            Assert.That(Cmp.Largest(new int[] { 9, 8, 7 }), Is.EqualTo(9));
            Assert.That(Cmp.Largest(new int[] { 8, 9, 7 }), Is.EqualTo(9));
            Assert.That(Cmp.Largest(new int[] { 7, 8, 9 }), Is.EqualTo(9));
        }

        [Test][Category("Long")]
        public void Dups()
        {
            Assert.That(Cmp.Largest(new int[] { 9, 7, 9 ,8 }), Is.EqualTo(9));
        }

        [Test]
        public void One()
        {
            Assert.That(Cmp.Largest(new int[] { 1 }), Is.EqualTo(1));
        }

        [Test]
        public void Negative()
        {
            int[] negatives = new int[]{-9,-8,-7};
            Assert.That(Cmp.Largest(negatives), Is.EqualTo(-7));
        }

        [Test]     
        public void Empty()
        {
            void CheckFunction()
            {
                Cmp.Largest(new int[] { });
            }
            Assert.Throws(typeof(ArgumentException), CheckFunction);
        }
    }
}
