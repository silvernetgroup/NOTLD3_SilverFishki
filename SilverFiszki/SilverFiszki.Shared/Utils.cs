using System;
using System.Collections.Generic;
using System.Text;

namespace SilverFiszki
{
    public static class Utils
    {
        public static string ConvertToTwoCharacterString(this int number)
        {
            if (number < 0)
            {
                throw new Exception("Number must be positive.");
            }
            else if (number >= 0 && number <= 9)
	        {
                return "0" + number;
	        }
            else
	        {
                return number.ToString();
            }
        }
    }
}
