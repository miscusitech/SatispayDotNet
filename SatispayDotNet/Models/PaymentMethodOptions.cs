using System.Text.Json.Serialization;

namespace SatispayDotNet.Models
{
    internal class PaymentMethodOptions
    {
        [JsonPropertyName("meal_voucher")]
        public MealVoucher MealVoucher { get; set; }
    }
}
