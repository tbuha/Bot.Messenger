﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Facebook.Messenger.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContentSize
    {
        full,
        tall,
        compact = 1
    }
}
