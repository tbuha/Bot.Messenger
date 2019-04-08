using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Messenger.Models
{
    public class LogOutButton : Button
    {
        protected override ButtonType _Type
        {
            get
            {
                return ButtonType.account_unlink;
            }
        }

        [JsonIgnore]
        public override string Title { get; set; }
    }
}
