using System.Text.Json.Serialization;

namespace SatispayDotNet.Models
{
    internal class PaymentOptions
    {
        [JsonPropertyName("partial_payment")]
        public bool PartialPayment { get; set; }
    }
}
