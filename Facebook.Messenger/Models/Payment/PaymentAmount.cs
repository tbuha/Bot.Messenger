using Newtonsoft.Json;

namespace Facebook.Messenger.Models
{
    public class PaymentAmount
    {
        [JsonProperty("currency")]
        public virtual string Currency { get; set; }

        [JsonProperty("amount")]
        public virtual string TotalAmount { get; set; }
    }
}