using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiderBBS.Model
{
    public static class LoginState
    {
        public static bool State { get; set; } = false;

        public static string UserName{get;set;}

        public static int UserID { get; set; }
    }
}
