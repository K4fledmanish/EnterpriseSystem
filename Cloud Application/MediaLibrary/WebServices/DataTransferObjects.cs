using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MediaLibraryWFC
{
    public class DataTransferObjects
    {

        [DataContract]
        public class Directors
        {
            [DataMember]
            public int DID { get; set; }

            [DataMember]
            public string DirectorName { get; set; }
        }

        [DataContract]
        public class Genre
        {
            [DataMember]
            public int GID { get; set; }

            [DataMember]
            public string GenreName { get; set; }
        }

        [DataContract]
        public class Language
        {
            [DataMember]
            public int LID { get; set; }

            [DataMember]
            public string LanguageName { get; set; }
        }


        [DataContract]
        public class Reserve
        {
            [DataMember]
            public int RID { get; set; }

            [DataMember]
            public string UserName { get; set; }

            [DataMember]
            public string Title { get; set; }

            [DataMember]
            public string ReservedDate { get; set; }
        }

        [DataContract]
        public class Borrow
        {
            [DataMember]
            public int BID { get; set; }

            [DataMember]
            public int UID { get; set; }

            [DataMember]
            public int MediaID { get; set; }

            [DataMember]
            public string BorrowDate { get; set; }

            [DataMember]
            public string ReturnDate { get; set; }

            [DataMember]
            public string ActualReturnDate { get; set; }

            [DataMember]
            public string BStatus { get; set; }

            [DataMember]
            public decimal LateFee { get; set; }
        }


        [DataContract]
        public class ReserveDTO
        {
            [DataMember]
            public int RID { get; set; }


            [DataMember]
            public string UserName { get; set; }

            [DataMember]
            public string Title { get; set; }

            [DataMember]
            public string ReservedDate { get; set; }
        }


    }
}