using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
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

            var actual = sut.validate(input);
            
            Assert.AreEqual(expected["start"].Hour, actual["start"].Hour);
            Assert.AreEqual(expected["end"].Hour, actual["end"].Hour);
        }

        [Test]
        public void ValidatorThrowsErrorWhenStartTimeValueIsNotParsable()
        {
            var input = new Dictionary<string, string> {{"start", "I_AM_NOT_GOOD"}, {"end", "1600"}};
            var expectedStart = new DateTime(2018, 1, 1, 12, 0, 0);
            var expectedEnd = new DateTime(2018, 1, 1, 16, 0, 0);
            var expected = new Dictionary<string, DateTime> {{"start", expectedStart}, {"end", expectedEnd}};
            
            var ex = Assert.Throws<FormatException>(() => sut.validate(input));
            Assert.AreEqual("Start Time is invalid!", ex.Message);
        }
    }
}