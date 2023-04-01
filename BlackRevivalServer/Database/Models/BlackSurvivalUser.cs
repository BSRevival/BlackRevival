using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.Database.Models
{
    public class BlackSurvivalUser
    {
        public UInt64 uid { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public String password { get; set; }

        public String country_code { get; set; }
        public DateTime last_seen { get; set; }
    }
}
