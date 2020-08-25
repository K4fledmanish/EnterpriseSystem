using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
   public class User
    {
        public int UID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int userLevel { get; set; }
        public string userEmail { get; set; }
    }
}
