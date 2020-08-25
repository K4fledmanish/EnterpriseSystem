using ControllerLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaLibrary.Models
{
    public class Media
    {
        public int MediaID { get; set; }

       
        public string Title { get; set; }


    
        public int Genere{ get; set; }

        
        public int Language { get; set; }

        public decimal Budget { get; set; }
        public int PublishYear { get; set;  }
        public int Director { get; set; }

        public string selection { get; set; }
        public string input { get; set; }
        public List<MediaDTO> listBooks = new List<MediaDTO>();
        
    }
    public enum Criteria
    {
        Title,
        DirectorName,
        Genre
    }
}