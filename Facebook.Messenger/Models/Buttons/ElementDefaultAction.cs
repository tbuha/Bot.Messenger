using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Messenger.Models
{
    public class ElementDefaultAction : UrlButton
    {
        [JsonIgnore]
        public override string Title { get; set; }
    }
}
