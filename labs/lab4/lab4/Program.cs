using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Prototype_Example2
{
    class MainApp
    {
        static void Main()
        {
            CardManager cardManager = new CardManager();
            List<string> values = new List<string>{ "7", "8", "9", "10", "J", "Q", "K", "A"};

            Card clubs = new Card("6", "clubs");
            Card diamonds = new Card("6", "diamonds");
            Card hearts = new Card("6", "hearts");
            Card spades = new Card("6", "spades");

            cardManager.Add(clubs);
            cardManager.Add(diamonds);
            cardManager.Add(hearts);
            cardManager.Add(spades);

            foreach (var a in values)
            {
                cardManager.Add((clubs.Clone() as Card).ChangeValue(a));
                cardManager.Add((diamonds.Clone() as Card).ChangeValue(a));
                cardManager.Add((hearts.Clone() as Card).ChangeValue(a));
                cardManager.Add((spades.Clone() as Card).ChangeValue(a));
            }

            foreach(var card in cardManager.cardDeck)
            {
                Console.WriteLine("{0, 8} | {1,1}", card.suit, card.value);
            }
            Console.ReadKey();
        }
    }

    [Serializable]
    abstract class CardPrototype
    {
        public abstract CardPrototype Clone();

        public abstract Card ChangeValue(string newVal);
    }

    [Serializable]
    class Card : CardPrototype
    {
        public string value;
        public string suit;

        public Card(string value, string suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public override Card ChangeValue(string newVal)
        {
            value = newVal;
            return this;
        }

        public override CardPrototype Clone()
        {
            Console.WriteLine($"Cloning card of {suit}.");

            return this.DeepClone() as CardPrototype;
        }

        public object DeepClone()
        {
            object clone = null;

            using (MemoryStream tempStream = new MemoryStream())
            {
                BinaryFormatter binFormatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.Clone));

                binFormatter.Serialize(tempStream, this);
                tempStream.Seek(0, SeekOrigin.Begin);

                clone = binFormatter.Deserialize(tempStream);
            }

            return clone;
        }

    }

    class CardManager
    {
        public List<Card> cardDeck = new List<Card>();

        public void Add(Card card)
        {
            cardDeck.Add(card);
        }
    }
}