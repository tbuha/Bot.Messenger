﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Facebook.Messenger.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProviderType
    {
        stripe = 1,
        paypal,
        token
    }
}