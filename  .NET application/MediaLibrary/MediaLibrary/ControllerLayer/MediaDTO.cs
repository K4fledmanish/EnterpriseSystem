using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLayer
{
   public class MediaDTO
    { 
        public int MediaID { get; set; }
        public string Title { get; set; }
        public string Genere { get; set; }
        public string Language { get; set; }
        public decimal Budget { get; set; }
        public int PublishYear { get; set; }
        public string Director { get; set; }
    }
}
