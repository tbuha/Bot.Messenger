﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Facebook.Messenger.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AudienceType
    {
        all = 1,
        custom,
        none
    }
}