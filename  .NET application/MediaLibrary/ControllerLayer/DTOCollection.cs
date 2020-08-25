using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLayer
{
    public class DTOCollection
    {


        public class Directors
        {

            public int DID { get; set; }
            public string DirectorName { get; set; }
        }

        public class Genre
        {
            public int GID { get; set; }
            public string GenreName { get; set; }
        }

        public class Language
        {
            public int LID { get; set; }
            public string LanguageName { get; set; }
        }

        public class Reserve
        {
            public int RID { get; set; }
            public string UserName { get; set; }
            public string Title { get; set; }
            public string ReservedDate { get; set; }
        }
        public class Borrow
        {
            public int BID { get; set; }
            public int UID { get; set; }
            public int MediaID { get; set; }
            public string BorrowDate { get; set; }
            public string ReturnDate { get; set; }
            public string ActualReturnDate { get; set; }
            public string Status { get; set; }
            public decimal LateFee { get; set; }
        }

        public class ReserveDTO
        {
            
            public int RID { get; set; }
            
            public string UserName { get; set; }
            
            public string Title { get; set; }
            
            public string ReservedDate { get; set; }
        }


        
    }
}