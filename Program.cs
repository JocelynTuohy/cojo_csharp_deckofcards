﻿using System;

namespace deckofcards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            // myDeck.printOut();
            myDeck.shuffle();
            foreach (Card card in myDeck.cards)
            // myDeck.printOut();
            myDeck.defaultDeck();
            // myDeck.printOut();
            myDeck.shuffle();
            Console.WriteLine(myDeck.deal().stringVal);
            Console.WriteLine(myDeck.deal().stringVal);
            // Console.WriteLine(myDeck.cards.Count);
            Player amanda = new Player("Amanda");
            amanda.draw(myDeck);
            amanda.draw(myDeck);
            amanda.draw(myDeck);
            amanda.draw(myDeck);
            amanda.draw(myDeck);
            Console.WriteLine(amanda.discard(0).val);
        }
    }
}
