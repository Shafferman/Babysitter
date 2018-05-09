using System;
using BabysitterKata;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TimeEntryTests
    {
        private TimeEntry sut;

        [SetUp]
        public void Init()
        {
            sut = new TimeEntry();
        }

        [Test]
        public void GivenStartTimeWhenTimeIsEnteredThenStartTimeShouldRoundDown()
        {
            sut.StartTime(new DateTime(2018, 1, 22, 12, 20, 15));

            Assert.AreEqual(new DateTime(2018, 1, 22, 12, 0, 0), sut.Start);
        }

        [Test]
        public void GivenEndedTimeWhenTimeIsEnteredThenEndTimeShouldRoundUp()
        {
            sut.EndTime(new DateTime(2018, 1, 22, 12, 20, 15));

            Assert.AreEqual(new DateTime(2018, 1, 22, 13, 0, 0), sut.End);
        }
    }
}
