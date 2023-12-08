using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace SejlBåd.Models
{
    public class CreditCard
    {
        
        [Required(ErrorMessage = "Must be a 16 Digit Number")]
        [Range(typeof(long), "1000000000000000", "9999999999999999", ErrorMessage = "CardNumber Must be 16 Digits")]
        public long CardNumber { get; set; }
        [Required(ErrorMessage = "required")]
        public DateTime ExpirationDate { get; set; }
        [Required(ErrorMessage = "Security Digits Required")]
        [Range(typeof(int),"100","999", ErrorMessage = "Must Be A 3 Digit Number")]
        public int SecurityCode { get; set; }

        public CreditCard(long cardNumber, DateTime expirationDate, int securityCode)
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
