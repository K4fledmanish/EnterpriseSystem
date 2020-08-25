using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MediaLibraryWFC
{

    [DataContract]
    public class User
    {
        [DataMember]
        public int UID { get; set; }

        [DataMember]
        public string userName { get; set; }

        [DataMember]
        public string password { get; set; }

        [DataMember]
        public int userLevel { get; set; }

        [DataMember]
        public string userEmail { get; set; }

    }
}