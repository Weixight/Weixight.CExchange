using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Weixight.CExchange.AgricGator.IntegratedModules
{
    public class FixedChar
    {
        public FixedChar()
        {

        }
        public string HomePageString(string MyMessage)
        {
			// If the string isn't null or empty
			int maxLength = 77;

			if (!String.IsNullOrEmpty(MyMessage))
			{
				// Return the appropriate string size
				return (MyMessage.Length <= maxLength) ? MyMessage : MyMessage.Substring(0, maxLength) + "...";
			}
			else
			{
				// Otherwise return the empty string
				return "";
			}
		}
		public  string StripHTML(string input)
		{
			var SpecialCharacter = Regex.Replace(input, @"[^0-9a-zA-Z]+", "");
			return Regex.Replace(SpecialCharacter, "<.*?>", String.Empty);
			
		}
	}
}
