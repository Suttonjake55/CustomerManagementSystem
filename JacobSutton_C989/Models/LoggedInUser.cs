using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace JacobSutton_C989.Models
{
    public static class LoggedInUser
    {
        public static string LoggedIn { get; set; }

        public static string Password { get; set; }
        public static int LoggedInId = 1;
    }
}
