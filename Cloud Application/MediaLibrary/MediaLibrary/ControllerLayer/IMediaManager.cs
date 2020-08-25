using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControllerLayer.DTOCollection;

namespace ControllerLayer
{
    public interface IMediaManager
    {

              List<MediaDTO> ViewMedia();

        List<MediaDTO> viewMediaByValue(string value, string column);

        List<Directors> getDirectors();

        List<Genre> getGenre();

        List<Language> getLanguage();


        int InsertMedia(String Title, int Genre, int Director, int Language, int PublishYear, decimal Budget);

        int UpdateMedia(String Title, int Genre, int Director, int Language, int PublishYear, decimal Budget, int MediaiId);

        int InsertGenre(String genreName);

        int InsertLanguage(String languageName);

        int InsertDirector(String directorName);

        int UpdateGenre(String genreName, int genreID);

        int UpdateLanguage(String languageName, int languageID);

        int UpdateDirector(String directorName, int directorID);

        void DeleteGenre(int genreID);

        void DeleteLanguage(int languageID);

        void DeleteDirector(int directorID);

        void DeleteMedia(int MediaID);



    }
}
