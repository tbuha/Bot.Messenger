﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Messenger.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SenderAction
    {
        mark_seen = 1,
        typing_on,
        typing_off
    }
}
