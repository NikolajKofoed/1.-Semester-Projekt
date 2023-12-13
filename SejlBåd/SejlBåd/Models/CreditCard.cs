using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace SejlBåd.Models
{
    public class CreditCard
    {

        [Required(ErrorMessage = "Credit card number is required.")]
        [Range(typeof(long), "1000000000000000", "9999999999999999")]
        public long CardNumber { get; set; }


        [Required(ErrorMessage = "Expiration date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ExpirationDate { get; set; }


        [Required(ErrorMessage = "CVV is required.")]
        [Range(typeof(int), "100", "999")]
        public int SecurityCode { get; set; }

        public CreditCard(long cardNumber, DateTime? expirationDate, int securityCode)
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
