using System;
namespace Aoc2023.Solutions
{
	public static class AocDay01
	{
        public static int Part01()
        {
            string[] lines = File.ReadAllLines("InputData/Day01.txt");

            int sum = 0;

            foreach (var line in lines)
            {
                string extractedNumberString = new String(line.Where(Char.IsDigit).ToArray());

                int calibVal = 0;

                if (extractedNumberString.Length > 0)
                {
                    if (extractedNumberString.Length == 1)
                    {
                        calibVal = Int32.Parse(extractedNumberString + "" + extractedNumberString);
                    }
                    else
                    {
                        calibVal = Int32.Parse(extractedNumberString[0] + "" + extractedNumberString[extractedNumberString.Length - 1]);
                    }
                }

                sum = sum + calibVal;
            }

            return sum;
        }

        public static int Part02()
        {
            string[] lines = File.ReadAllLines("InputData/Day01.txt");

            var numbers = new Dictionary<int, string>();
            numbers.Add(1, "one");
            numbers.Add(2, "two");
            numbers.Add(3, "three");
            numbers.Add(4, "four");
            numbers.Add(5, "five");
            numbers.Add(6, "six");
            numbers.Add(7, "seven");
            numbers.Add(8, "eight");
            numbers.Add(9, "nine");

            int sum = 0;

            foreach (var line in lines)
            {
                int calibVal = 0;

                var indexes = new Dictionary<int, string>();

                for (int i = 0; i < line.Length; i++)
                {
                    var character = line[i];
                    if (Char.IsDigit(character))
                    {
                        indexes.Add(i, character.ToString());
                    }

                    foreach (var number in numbers)
                    {
                        var subString = line.Substring(i);

                        if (subString.StartsWith(number.Value))
                        {
                            indexes.Add(i, number.Key.ToString());
                        }
                    }
                }

                // In this example, the calibration values are 29, 83, 13, 24, 42, 14, and 76. 
                // Adding these together produces 281.

                if (indexes.Count() > 0)
                {
                    var orderedIndex = indexes.OrderBy(c => c.Key);

                    if (orderedIndex.Count() == 1)
                    {
                        calibVal = Int32.Parse(orderedIndex.First().Value + "" + orderedIndex.First().Value);
                    }
                    else
                    {
                        calibVal = Int32.Parse(orderedIndex.First().Value + "" + orderedIndex.Last().Value);
                    }
                }

                Console.WriteLine(line + " ==> " + calibVal);

                sum = sum + calibVal;
            }

            return sum;
        }
    }
}

