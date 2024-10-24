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

                cardHand.Card1 = hand[0].ToString();
                cardHand.Card1Value = GetCardValue(hand[0]);

                cardHand.Card2 = hand[1].ToString();
                cardHand.Card2Value = GetCardValue(hand[1]);

                cardHand.Card3 = hand[2].ToString();
                cardHand.Card3Value = GetCardValue(hand[2]);

                cardHand.Card4 = hand[3].ToString();
                cardHand.Card4Value = GetCardValue(hand[3]);

                cardHand.Card5 = hand[4].ToString();
                cardHand.Card5Value = GetCardValue(hand[4]);

                list.Add(cardHand);
            }

            list.Sort();

            return sum;
        }

        public static KIND GetKind(string hand)
        {
            return KIND.FiveOfKind;
        }

        public static int GetCardValue(char card)
        {
            //A, K, Q, J, T, // 9, 8, 7, 6, 5, 4, 3, or 2
            if (card == 'A') return 100;
            if (card == 'K') return 50;
            if (card == 'Q') return 30;
            if (card == 'J') return 20;
            if (card == 'T') return 10;
            if (card == '9') return 9;
            if (card == '8') return 8;
            if (card == '7') return 7;
            if (card == '6') return 6;
            if (card == '5') return 5;
            if (card == '4') return 4;
            if (card == '3') return 3;
            if (card == '2') return 2;

            throw new Exception("Invalid card: " + card);
        }
    }

    public class CardHand : IComparable<CardHand>
    {
        public string Hand { get; set; }

        public int Bid { get; set; }

        public KIND Kind { get; set; }

        public string Card1 { get; set; }
        public int Card1Value { get; set; }

        public string Card2 { get; set; }
        public int Card2Value { get; set; }

        public string Card3 { get; set; }
        public int Card3Value { get; set; }

        public string Card4 { get; set; }
        public int Card4Value { get; set; }

        public string Card5 { get; set; }
        public int Card5Value { get; set; }

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

