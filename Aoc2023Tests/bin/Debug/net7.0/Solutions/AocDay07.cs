using System;
using System.Security.Cryptography;

namespace Aoc2023.Solutions
{
	public static class AocDay07
    {
        public static int Part01()
        {
            string[] lines = File.ReadAllLines("InputData/Day07.txt");

            int sum = 0;

            var list = new List<CardHand>();

            foreach (var line in lines)
            {
                var hand = line.Split(" ")[0];
                var bid = Int32.Parse(line.Split(" ")[1]);

                var cardHand = new CardHand();
                cardHand.Hand = hand;
                cardHand.Bid = bid;

                

                list.Add(cardHand);
            }

            list.Sort();

            return sum;
        }

        public static KIND GetKind(string hand)
        {
            return KIND.FiveOfKind;
        }
    }

    public class CardHand : IComparable<CardHand>
    {
        public string Hand { get; set; }

        public int Bid { get; set; }

        public KIND Kind { get; set; }

        public string Card1 { get; set; }
        public string Card1Value { get; set; }

        public string Card2 { get; set; }
        public string Card2Value { get; set; }

        public string Card3 { get; set; }
        public string Card3Value { get; set; }

        public string Card4 { get; set; }
        public string Card4Value { get; set; }

        public string Card5 { get; set; }
        public string Card5Value { get; set; }

        public int CompareTo(CardHand that)
        {
            if (Bid == that.Bid)
            {
                return 0;
            }
            else if(Bid < that.Bid)
            {
                return 1;
            }

            return -1;
        }
    }

    public enum KIND
    {
        FiveOfKind = 1,
        FourofKind = 2,
        FullHouse = 3,
        ThreeOfKind = 4,
        TwoPair = 5,
        OnePair = 6,
        HighCard = 7
    }
}

