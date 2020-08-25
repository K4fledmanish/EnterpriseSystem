using DataModel.UserMediaDataTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{ 
    public class MediaDataAccess
    {
        private UserMediaData umd;
        private ViewMediaTableAdapter viewMediaTableAdapter;


        public MediaDataAccess() // Creacting constructor
        {
            umd = new UserMediaData();
            viewMediaTableAdapter = new ViewMediaTableAdapter();

        }
        public UserMediaData.ViewMediaDataTable MediaList()
        {
            viewMediaTableAdapter.Fill(umd.ViewMedia);
            return umd.ViewMedia;

        }

        public UserMediaData.ViewMediaDataTable MediaListByGenre(string genreName)
        {
            viewMediaTableAdapter.FillBygenre(umd.ViewMedia, genreName); //Using Custome Select query from database
            return umd.ViewMedia;

        }

        public UserMediaData.ViewMediaDataTable MediaListByBudget(int budget)
        {
            viewMediaTableAdapter.FillByBudget(umd.ViewMedia, budget); // Using Custome query
            return umd.ViewMedia;

        }

        public UserMediaData.ViewMediaDataTable MediaListByPublishYear(int publishYear)
        {
            viewMediaTableAdapter.FillByPublishYear(umd.ViewMedia, publishYear); // Using Custome query
            return umd.ViewMedia;

        }
    }

}
