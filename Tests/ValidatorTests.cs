using System;
using System.Collections.Generic;
using BabysitterKata;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ValidatorTests
    {
        private Validator sut;

        [SetUp]
        public void SetUp()
        {
            sut = new Validator();
        }

        [Test]
        public void ValidatorReturnsDateTimeDictionary()
        {
            var input = new Dictionary<string, string> {{"start", "1200"}, {"end", "1600"}};
            var expectedStart = new DateTime(2018, 1, 1, 12, 0, 0);
            var expectedEnd = new DateTime(2018, 1, 1, 16, 0, 0);
            var expected = new Dictionary<string, DateTime> {{"start", expectedStart}, {"end", expectedEnd}};

            var actual = sut.Validate(input);

            Assert.AreEqual(expected["start"].Hour, actual["start"].Hour);
            Assert.AreEqual(expected["end"].Hour, actual["end"].Hour);
        }

        [Test]
        public void ValidatorThrowsErrorWhenStartTimeValueIsNotParsable()
        {
            var input = new Dictionary<string, string> {{"start", "I_AM_NOT_GOOD"}, {"end", "1600"}};
            Assert.Throws<InputException>(() => sut.Validate(input));
        }

        [Test]
        public void ValidatorThrowsErrorWhenEndTimeValueIsNotParsable()
        {
            var input = new Dictionary<string, string> {{"start", "1200"}, {"end", "I_AM_NOT_GOOD"}};
            Assert.Throws<InputException>(() => sut.Validate(input));
        }

        [Test]
        public void ValidatorErrorWhenEndTimeBeforeStartTime()
        {
            var input = new Dictionary<string, string> {{"start", "1600"}, {"end", "1200"}};
            Assert.Throws<InputException>(() => sut.Validate(input));
        }

        [Test]
        public void ValidatorErrorWhenEndTimeIsSameAsStartTime()
        {
            var input = new Dictionary<string, string> {{"start", "1600"}, {"end", "1600"}};
            Assert.Throws<InputException>(() => sut.Validate(input));
        }
        
    }
}