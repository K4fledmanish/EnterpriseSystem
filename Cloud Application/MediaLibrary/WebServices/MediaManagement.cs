using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using static MediaLibraryWFC.DataTransferObjects;

namespace MediaLibraryWFC
{
    public interface MediaManagement
    {
        [OperationContract]
        List<MediaDataTransferObjects> ViewMedia();

        [OperationContract]
        List<MediaDataTransferObjects> viewMediaByValue(string value, string column);

        [OperationContract]
        List<Directors> getDirectors();

        [OperationContract]
        List<Genre> getGenre();

        [OperationContract]
        List<Language> getLanguage();

        [OperationContract]
        int InsertMedia(String Title, int Genre, int Director, int Language, int PublishYear, decimal Budget);

        [OperationContract]
        int UpdateMedia(String Title, int Genre, int Director, int Language, int PublishYear, decimal Budget, int MediaiId);

        [OperationContract]
        int InsertGenre(String genreName);

        [OperationContract]
        int InsertLanguage(String languageName);

        [OperationContract]
        int InsertDirector(String directorName);

        [OperationContract]
        int UpdateGenre(String genreName, int genreID);

        [OperationContract]
        int UpdateLanguage(String languageName, int languageID);

        [OperationContract]
        int UpdateDirector(String directorName, int directorID);

        [OperationContract]
        void DeleteGenre(int genreID);

        [OperationContract]
        void DeleteLanguage(int languageID);

        [OperationContract]
        void DeleteDirector(int directorID);

        [OperationContract]
        void DeleteMedia(int MediaID);
    }
}
