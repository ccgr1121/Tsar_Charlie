using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src
{
    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Thumbprint Thumprint { get; set; }
    }
}
