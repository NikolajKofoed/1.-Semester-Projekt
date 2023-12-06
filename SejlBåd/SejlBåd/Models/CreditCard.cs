namespace SejlBåd.Models
{
    public class CreditCard
    {

        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public int SecurityCode { get; set; }

        public CreditCard(string cardNumber, string expirationDate, int securityCode)
        {
            CardNumber = cardNumber;
            ExpirationDate = expirationDate;
            SecurityCode = securityCode;

        }

        public CreditCard()
        {
        }

    }
}
