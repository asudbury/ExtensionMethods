namespace Scorchio.ExtensionMethods.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DateTimeExtensionsTests
    {
        /// <summary>
        /// Tests the is yesterday false..
        /// </summary>
        /// <param name="input">The input.</param>
        /// <param name="expected">The expected.</param>
        [Test]
        public void TestIsYesterdayFalse(
            DateTime input,
            string expected)
        {
            DateTime inputDateTime = DateTime.Today;

            bool output = inputDateTime.IsYesterday();

            Assert.AreEqual(output, false);
        }

        /// <summary>
        /// Tests the is yesterday true.
        /// </summary>
        [Test]
        public void TestIsYesterdayTrue()
        {
            DateTime inputDateTime = DateTime.Today.AddDays(-1);

            bool output = inputDateTime.IsYesterday();

            Assert.AreEqual(output, true);
        }

        /// <summary>
        /// Tests the is today false.
        /// </summary>
        [Test]
        public void TestIsTodayFalse()
        {
            DateTime inputDateTime = DateTime.Today.AddDays(2);

            bool output = inputDateTime.IsToday();

            Assert.AreEqual(output, false);
        }

        /// <summary>
        /// Tests the is today true.
        /// </summary>
        [Test]
        public void TestIsTodayTrue()
        {
            DateTime inputDateTime = DateTime.Today;

            bool output = inputDateTime.IsToday();

            Assert.AreEqual(output, true);
        }

        /// <summary>
        /// Tests the is tomorrow false.
        /// </summary>
        [Test]
        public void TestIsTomorrowFalse()
        {
            DateTime inputDateTime = DateTime.Today.AddDays(2);

            bool output = inputDateTime.IsTomorrow();

            Assert.AreEqual(output, false);
        }

        /// <summary>
        /// Tests the is tomorrow true.
        /// </summary>
        [Test]
        public void TestIsTomorrowTrue()
        {
            DateTime inputDateTime = DateTime.Today.AddDays(1);

            bool output = inputDateTime.IsTomorrow();

            Assert.AreEqual(output, true);
        }
    }
}
