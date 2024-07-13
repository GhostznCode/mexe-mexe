
namespace MexeMexe.Model
{
    public class Card
    {
        public int Value { get; set; }
        public SuitEnum Suit { get; set; }

    }


    public enum SuitEnum
    {
        CLUBS,
        DIAMONDS,
        HEARTS,
        SPADES,
    }
}

