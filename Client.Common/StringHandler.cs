using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Common
{
    public static class StringHandler
    {
        public static string Tidy(string inString)
        {
            var returnString = "";
            inString = inString.Trim();
       
            int stringLength = inString.Length;

            var changeNext = false;
            var charNum = 1;

            foreach (char letter in inString)
            {
                
                if (charNum == 1) changeNext = true;
                if (changeNext)
                {
                    returnString = returnString + char.ToUpper(letter);
                    changeNext = false;
                }
                else
                {
                    returnString = returnString + char.ToLower(letter);
                }
                charNum++;
                if (char.IsWhiteSpace(letter)) changeNext = true;

            }
            return returnString;
        }
    }
}
