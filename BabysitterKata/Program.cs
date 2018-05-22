using System;

namespace BabysitterKata
{
	public class MainClass
	{
		public static void Main(string[] args)
		{


		}

		public static string[] ParseArgs(string[] args)
		{
			Console.WriteLine("BabySitter Go!");

			//if (args.Length < 2)
			//    throw new ArgumentException("Need \"start time\" or \"stop time\"");
			//var commandArg = args[0];
			//var timeArg = args[1];

			//Console.WriteLine(commandArg);

			//TimeEntry timeEntry = new TimeEntry();

			//DateTime parsedTime = DateTime.Parse(timeArg);

			//switch (commandArg)
			//{
			//    case "start":
			//        timeEntry.StartTime(parsedTime);
			//        break;
			//    case "stop":
			//        timeEntry.EndTime(parsedTime);
			//        break;
			//    default:
			//        throw new ArgumentException("Only say start or stop, please.");
			//}

			//Console.WriteLine("Time Entry: ");
			//Console.WriteLine(timeEntry.Start);
			//Console.WriteLine(timeEntry.End);

			return args;
		}
	}
}
