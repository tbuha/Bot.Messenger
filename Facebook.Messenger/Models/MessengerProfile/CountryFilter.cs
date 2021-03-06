﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Facebook.Messenger.Models
{
    public class CountryFilter
    {
        [JsonProperty("whitelist")]
        public virtual List<string> Whitelist { get; set; }

        [JsonProperty("blacklist")]
        public virtual List<string> Blacklist { get; set; }
    }
}