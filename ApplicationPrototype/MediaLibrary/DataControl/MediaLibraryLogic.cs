using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataControl
{ 
   public class MediaLibraryLogic
    {
        private MediaDataAccess mediaDataAccess;
        private UserMediaData.ViewMediaDataTable mediaTable;


        public MediaLibraryLogic()
        {
            mediaDataAccess = new MediaDataAccess(); 
            // Accessing from Data Model
            mediaTable = new UserMediaData.ViewMediaDataTable(); //Database

        }

        public List<MediaDataView> MediaList() {

            List<MediaDataView> mdView = new List<MediaDataView>();
            mediaTable = mediaDataAccess.MediaList();

            //List of values in a table.

            foreach (UserMediaData.ViewMediaRow row in mediaTable.Rows)
            {
                MediaDataView mediaData = MediaDataView.Parse(row);
                mdView.Add(mediaData);
            }
            return mdView;
        }

        public List<MediaDataView> ListByGenre(string genreName)
        {
            List<MediaDataView> mediaDataViews = new List<MediaDataView>(); 
            mediaTable = mediaDataAccess.MediaListByGenre(genreName); // listing according to Genre

            foreach (UserMediaData.ViewMediaRow row in mediaTable.Rows)
            {
                MediaDataView mediaDataView = MediaDataView.Parse(row);
                mediaDataViews.Add(mediaDataView);
            }
            return mediaDataViews;
        }

        public List<MediaDataView> ListByBudget(int budget)
        {
            List<MediaDataView> mediaDataViews = new List<MediaDataView>();
            mediaTable = mediaDataAccess.MediaListByBudget(budget);

            foreach (UserMediaData.ViewMediaRow row in mediaTable.Rows)
            {
                MediaDataView mediaDataView = MediaDataView.Parse(row);
                mediaDataViews.Add(mediaDataView);
            }
            return mediaDataViews;
        }

        public List<MediaDataView> ListByPublishYear(int publishYear)
        {
            List<MediaDataView> mediaDataViews = new List<MediaDataView>();
            mediaTable = mediaDataAccess.MediaListByPublishYear(publishYear);

            foreach (UserMediaData.ViewMediaRow row in mediaTable.Rows)
            {
                MediaDataView mediaDataView = MediaDataView.Parse(row);
                mediaDataViews.Add(mediaDataView);
            }
            return mediaDataViews;
        }


    }
}
