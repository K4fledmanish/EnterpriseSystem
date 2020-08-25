using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataControl
{ 
    public class MediaDataView
    {
        //Getter and setterfunction of table elements.
        public int MediaID { get; set; }

            public string Title { get; set; }

        public string GenreName { get; set; }

        public string DirectorName { get; set; }
        public string LanguageName { get; set; }

        public int PublishYear { get; set; }

        public decimal Budget { get; set; }



        

        public static MediaDataView Parse(UserMediaData.ViewMediaRow viewMedia) {

            if (viewMedia == null)
                return null;

            MediaDataView mdv = new MediaDataView();
            mdv.MediaID = viewMedia.MediaID;
            mdv.Title = viewMedia.Title;
            mdv.GenreName = viewMedia.GenreName;
            mdv.DirectorName = viewMedia.DirectorName;
            mdv.LanguageName = viewMedia.LanguageName;
            mdv.PublishYear = viewMedia.PublishYear;
            mdv.Budget = viewMedia.Budget;

            return mdv;
        }

    }
}
