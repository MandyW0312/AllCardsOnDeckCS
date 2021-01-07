using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of deck of cards
            var deckOfCardsList = new List<string>() { "Ace of Clubs", "Two of Clubs", "Three of Clubs", "Four of Clubs", "Five of Clubs", "Six of Clubs", "Seven of Clubs", "Eight of Clubs", "Nine of Clubs", "Ten of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs", "Ace of Spades", "Two of Spades", "Three of Spades", "Four of Spades", "Five of Spades", "Six of Spades", "Seven of Spades", "Eight of Spades", "Nine of Spades", "Ten of Spades", "Jack of Spades", "Queen of Spades", "King of Spades", "Ace of Hearts", "Two of Hearts", "Three of Hearts", "Four of Hearts", "Five of Hearts", "Six of Hearts", "Seven of Hearts", "Eight of Hearts", "Nine of Hearts", "Ten of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts", "Ace of Diamonds", "Two of Diamonds", "Three of Diamonds", "Four of Diamonds", "Five of Diamonds", "Six of Diamonds", "Seven of Diamonds", "Eight of Diamonds", "Nine of Diamonds", "Ten of Diamonds", "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds" };

            //numberOfCards = length of our deck
            var numberOfCards = deckOfCardsList.Count;

            //for rightIndex from numberOfCards - 1 down to 1 do:
            for (var rightIndex = numberOfCards - 1; rightIndex >= 0; rightIndex--)
            {
                //leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex.
                var leftIndex = new Random().Next(0, rightIndex);
                //Now swap the values at rightIndex and leftIndex by doing this:
                //leftCard = the value from deck[leftIndex]
                var leftCard = deckOfCardsList[leftIndex];
                //rightCard = the value from deck[rightIndex]
                var rightCard = deckOfCardsList[rightIndex];
                //deck[rightIndex] = leftCard
                deckOfCardsList[rightIndex] = leftCard;
                //deck[leftIndex] = rightCard
                deckOfCardsList[leftIndex] = rightCard;
            }


            var newCardList = new List<string>();
            foreach (var card in deckOfCardsList)
            {
                newCardList.Add(card);
            }

            Console.WriteLine(newCardList[0]);
            Console.WriteLine(newCardList[1]);
        }
    }
}

