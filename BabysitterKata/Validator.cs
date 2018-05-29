using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace BabysitterKata
{
    public class Validator
    {
        public Dictionary<string, DateTime> validate(Dictionary<string, string> input)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            
            var validatedDictionary = new Dictionary<string, DateTime>();

            try
            {
                validatedDictionary["start"] = DateTime.ParseExact(input["start"], "HHmm", provider);
            }
            catch (FormatException ex)
            {
                throw new FormatException("Start Time is invalid!");
            }

            validatedDictionary["end"] = DateTime.ParseExact(input["end"], "HHmm", provider);

            return validatedDictionary;
        }
    }
}