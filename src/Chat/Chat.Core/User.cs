using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core
{
    public class User
    {
        public string Nickname { get; set; }
        //public UserState State { get; set; }

        enum UserState
        {
            Available,
            Offline,
            Away
        };
    }
}
