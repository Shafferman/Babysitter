using System;
namespace BabysitterKata
{
	public class TimeEntry
	{
		private DateTime started;
		private DateTime ended;

		public DateTime Start => started;

		public DateTime End => ended;

		public TimeEntry()
		{
		}

		public void StartTime(DateTime dateTime)
		{
			started = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0);
		}

		public void EndTime(DateTime dateTime)
		{
			ended = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0);
			ended = ended.AddHours(dateTime.Minute > 0 ? 1 : 0);
		}
	}
}
