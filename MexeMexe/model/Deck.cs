
namespace MexeMexe.Model
{
    public class Deck
    {

        public Deck()
        {
            this.Cards = [];
            foreach (SuitEnum suit in Enum.GetValues(typeof(SuitEnum)))
            {
                for (int i = 1; i <= 13; i++)
                {
                    this.Cards.Add(new Card { Value = i, Suit = suit });
                }
            }
        }

        public List<Card> Cards { get; set; }
        public void Print()
        {
            foreach (Card card in this.Cards)
            {
                Console.WriteLine("{0} {1}", card.Value, card.Suit);
            }
        }

    }

}