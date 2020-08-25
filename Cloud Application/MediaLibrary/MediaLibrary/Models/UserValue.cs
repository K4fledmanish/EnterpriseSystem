using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaLibrary.Models
{
    public class UserValue
    {
        public int UID { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string password { get; set; }
        public int loginTry { get; set; }
        public int userLevel { get; set; }
    }
}