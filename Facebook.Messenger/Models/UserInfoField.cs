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
    public enum UserInfoField
    {
        shipping_address = 1,
        contact_name,
        contact_phone,
        contact_email
    }
}
