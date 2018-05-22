using NUnit.Framework;
using BabysitterKata;

namespace Tests
{
	[TestFixture]
	public class ProgramTests
	{

		[Test]
		public void WeCanCreateAParser()
		{

			string[] args = {
				"start",
				"12:01"
			};

			MyParser sut = new MyParser(args);

			Assert.AreEqual(sut.args, args);
		}

		[Test]
		public void ShouldHaveADictionaryWithStartTime()
		{
			string[] args = {
				"start",
				"12:01"
			};

			MyParser sut = new MyParser(args);

			var theDictionary = sut.GetArgumentDictionary();

			Assert.AreEqual(theDictionary["start"], "12:01");
		}

		[Test]
		public void ShouldHaveADictionaryWithEndTime()
		{
			string[] args = {
				"end",
				"5:30"
			};

			MyParser sut = new MyParser(args);

			var theDictionary = sut.GetArgumentDictionary();

			Assert.AreEqual(theDictionary["end"], "5:30");
		}

		[Test]
		public void ShouldHaveStartAndEndTime()
		{
			string[] args = {
				"start",
				"12:01",
				"end",
				"5:30"
			};

			MyParser sut = new MyParser(args);

			var theDictionary = sut.GetArgumentDictionary();

			Assert.AreEqual(theDictionary["end"], "5:30");
			Assert.AreEqual(theDictionary["start"], "12:01");
		}
		
		[Test]
		public void ShouldDropLastArgWhenOddNumberOfArgs()
		{
			string[] args = {
				"start",
				"12:01",
				"end"
			};

			MyParser sut = new MyParser(args);

			var theDictionary = sut.GetArgumentDictionary();

			Assert.False(theDictionary.ContainsKey("end"));
			Assert.AreEqual(theDictionary["start"], "12:01");
		}
	}
}