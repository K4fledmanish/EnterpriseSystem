using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MediaLibraryWFC
{
    [DataContract]
    public class MediaDataTransferObjects
    {
        [DataMember]
        public int MediaID { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Genere { get; set; }

        [DataMember]
        public string Language { get; set; }

        [DataMember]
        public decimal Budget { get; set; }

        [DataMember]
        public int PublishYear { get; set; }

        [DataMember]
        public string Director { get; set; }
    }
}