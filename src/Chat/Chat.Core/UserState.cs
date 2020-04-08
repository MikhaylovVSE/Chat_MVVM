using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core
{
    public class User
    {
        public UserState State { get; set; }

        public enum UserState
        {
            Available,
            Offline,
            Away
        };
    }
}
