using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core
{
    public class User
    {
        private UserState State { get; set; } //почему здесь модификатор private?

        enum UserState
        {
            Available,
            Offline,
            Away
        };
    }
}
}
