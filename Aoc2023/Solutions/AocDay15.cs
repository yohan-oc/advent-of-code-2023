using System;
namespace Aoc2023.Solutions
{
	public static class AocDay15
	{
        public static int Part01()
        {
            string[] lines = File.ReadAllLines("InputData/Day15.txt");

            int sum = 0;

            var codes = lines[0].Split(",");

            foreach(var code in codes)
            {
                sum = sum + CalculateCodeValue(code);
            }

            return sum;
        }

        public static int CalculateCodeValue(string code)
        {
            int currentValue = 0;

            foreach(var c in code)
            {
                int asciiValue = (int)c + currentValue;

                currentValue = asciiValue * 17;

                currentValue = currentValue % 256;
            }
            return currentValue;
        }
    }
}

