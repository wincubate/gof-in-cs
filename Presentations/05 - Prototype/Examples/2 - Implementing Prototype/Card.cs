using System;

namespace Wincubate.PrototypeExamples
{
    enum Suit
    {
        Spades,
        Clubs,
        Hearts,
        Diamonds
    }

    enum Rank
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    class Card : ICloneable
    {
        public Suit Suit { get; }
        public Rank Rank { get; }

        #region ICloneable Members

        //public object Clone() => new Card(Suit, Rank);

        // ...or...

        public object Clone() => this.MemberwiseClone() as Card;

        #endregion

        public Card( Suit suit, Rank rank )
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            char rankOutput;
            switch (Rank)
            {
                case Rank.Two:
                case Rank.Three:
                case Rank.Four:
                case Rank.Five:
                case Rank.Six:
                case Rank.Seven:
                case Rank.Eight:
                case Rank.Nine:
                    rankOutput = (char)('2' + ((char)(Rank - Rank.Two)));
                    break;
                case Rank.Ten:
                    rankOutput = 'T';
                    break;
                case Rank.Jack:
                    rankOutput = 'J';
                    break;
                case Rank.Queen:
                    rankOutput = 'Q';
                    break;
                case Rank.King:
                    rankOutput = 'K';
                    break;
                case Rank.Ace:
                    rankOutput = 'A';
                    break;
                default:
                    rankOutput = '?';
                    break;
            }

            char suitOutput;
            switch (Suit)
            {
                case Suit.Clubs:
                    suitOutput = 'c';
                    break;
                case Suit.Diamonds:
                    suitOutput = 'd';
                    break;
                case Suit.Hearts:
                    suitOutput = 'h';
                    break;
                case Suit.Spades:
                    suitOutput = 's';
                    break;
                default:
                    suitOutput = '?';
                    break;
            }

            return $"{rankOutput}{suitOutput}";
        }
    }
}