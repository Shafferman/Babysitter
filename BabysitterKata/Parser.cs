using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;

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
			var outDictionary = new Dictionary<string, string>();
			for (int i = 0; i < args.Length; i += 2)
			{
				try
				{
					outDictionary[args[i]] = args[i + 1];
				}
				catch(IndexOutOfRangeException exception)
				{
				}
			}

			return outDictionary;

		}
	}
}
