namespace SejlBåd.Models
{
    public class CreditCard
    {
        public enum CardType { Visa, Paypal }
        public CreditCard()
        {
        }

        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public int SecurityCode { get; set; }
        public CardType Card { get; set; }

        public CreditCard(string cardNumber, string expirationDate, int securityCode)
        {
            CardNumber = cardNumber;
            ExpirationDate = expirationDate;
            SecurityCode = securityCode;

        }

        public override string ToString()
        {
            return $"{{{nameof(CardNumber)}={CardNumber}, {nameof(ExpirationDate)}={ExpirationDate}, {nameof(SecurityCode)}={SecurityCode.ToString()}, {nameof(Card)}={Card.ToString()}}}";
        }
    }
}
