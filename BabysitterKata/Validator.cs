using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace BabysitterKata
{
    public class Validator
    {
        public Dictionary<string, DateTime> Validate(Dictionary<string, string> input)
        {
            var end = input["end"];
            var start = input["start"];

            var validatedDictionary = new Dictionary<string, DateTime>()
            {
                {"end", CreateTime(end)},
                {"start", CreateTime(start)}
            };

            ValidateEndtimeIsAfterStartTime(validatedDictionary["start"], validatedDictionary["end"]);
            
            return validatedDictionary;
        }

        private static void ValidateEndtimeIsAfterStartTime(DateTime start, DateTime end)
        {
            if (end <= start)
            {
                throw new InputException("End time should be after start time");
            }
        }

        private DateTime CreateTime(string time)
        {
            try
            {
                CultureInfo provider = CultureInfo.InvariantCulture;
                
                return DateTime.ParseExact(time, "HHmm", provider);
            }
            catch (FormatException e)
            {
                throw new InputException("Invalid time entered");
            }
        }
    }
}