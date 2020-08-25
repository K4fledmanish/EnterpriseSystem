using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaLibrary.Models
{
    public class Borrow
    {

        
       
       public int BID { get; set; }
         public int UID { get; set; }
            public int MediaID { get; set; }
            public string BorrowDate { get; set; }
            public string ReturnDate { get; set; }
            public string ActualReturnDate { get; set; }
           
            public decimal LateFee { get; set; }
        
    }
}