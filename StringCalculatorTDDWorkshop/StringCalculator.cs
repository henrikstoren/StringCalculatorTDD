using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTDDWorkshop
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            var result = 0;
            var separatorsToUse = new string[] { "," };
            var numberPart = input;
            if (!string.IsNullOrEmpty(input))
            {
                if (input.StartsWith("//"))
                {
                    var stringParts = input.Split('\n');

                    var separatorPart = stringParts[0].Replace("/","");
                    var separators = separatorPart.Substring(1, (separatorPart.Length - 2));
                    separatorsToUse = separators.Split(new string[] { "][" }, StringSplitOptions.None);

                    numberPart = stringParts[1];
                }

                var numbers = numberPart.Split(separatorsToUse, StringSplitOptions.None);
                foreach (var num in numbers)
                {
                    var add = Int32.Parse(num);
                    if(add < 1000)
                    {
                        result += add;
                    }
                }
            }
            return result;
        }
    }
}
