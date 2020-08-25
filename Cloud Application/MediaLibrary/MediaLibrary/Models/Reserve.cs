using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaLibrary.Models
{
    public class Reserve
    {
        public int RID { get; set; }
        public int UID { get; set; }
        public int MediaID { get; set; }
        public string ReservedDate { get; set; }
    }
}