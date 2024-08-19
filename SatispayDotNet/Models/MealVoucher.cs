using System.Text.Json.Serialization;

namespace SatispayDotNet.Models
{
    internal class MealVoucher
    {
        [JsonPropertyName("enable")]
        public bool Enable { get; set; }
        [JsonPropertyName("max_amount_unit")]
        public int MaxAmountUnit { get; set; }
        [JsonPropertyName("max_number")]
        public int MaxNumber { get; set; }
    }
}
