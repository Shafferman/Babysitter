using System;
using System.Collections.Generic;

namespace BabysitterKata
{
	public class MyParser
	{
		public string[] args;

		public MyParser(string[] args)
		{
			this.args = args;
		}

		public Dictionary<string, string> GetArgumentDictionary()
		{
			return new Dictionary<string, string>() {
				{"endTime", args[3]},
				{"startTime", args[1]}
			};
		}
	}
}
