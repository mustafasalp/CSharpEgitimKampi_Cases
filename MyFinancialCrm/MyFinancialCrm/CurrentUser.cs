using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinancialCrm.Models;

namespace MyFinancialCrm
{
    public static class CurrentUser
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static bool IsAdmin { get; set; } // Lazım tabiki.
    }
}
