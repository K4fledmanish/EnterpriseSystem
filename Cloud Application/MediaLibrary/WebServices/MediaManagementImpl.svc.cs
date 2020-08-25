using ModelLayer;
using ModelLayer.UserDataTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using static MediaLibraryWFC.DataTransferObjects;

namespace MediaLibraryWFC
{

    public class MediaManagerImpl : MediaManagement
    {
        List<MediaDataTransferObjects> mediaDTOs = new List<MediaDataTransferObjects>();

        ModelLayer.UserData.TabMediaDataTable tabMedias = new ModelLayer.UserData.TabMediaDataTable();

        ModelLayer.UserDataTableAdapters.TabMediaTableAdapter tabMediaTableAdapter = new ModelLayer.UserDataTableAdapters.TabMediaTableAdapter();

        public List<MediaDataTransferObjects> ViewMedia()
        {

            int rowCount = tabMediaTableAdapter.MediaView(tabMedias);
            if (rowCount > 0)
            {
                tabMediaTableAdapter.MediaView(tabMedias);
                foreach (DataRow dr in tabMedias.Rows)
                {
                    MediaDataTransferObjects mediaDTO = new MediaDataTransferObjects();

                    try
                    {

                        mediaDTO.MediaID = Int32.Parse(dr["MediaID"].ToString());
                        mediaDTO.Title = dr["Title"].ToString();
                        mediaDTO.Genere = dr["GenreName"].ToString();
                        mediaDTO.Language = dr["LanguageName"].ToString();
                        mediaDTO.Budget = decimal.Parse(dr["Budget"].ToString());
                        mediaDTO.PublishYear = Int32.Parse(dr["PublishYear"].ToString());
                        mediaDTO.Director = dr["DirectorName"].ToString();
                    }
                    catch
                    {

                       
                    }

                    mediaDTOs.Add(mediaDTO);

                }
            }
            return mediaDTOs;
        }

        public int InsertMedia(String Title, int Genre, int Director, int Language, int PublishYear, decimal Budget)
        {
            int countRow = 0;
            if (Title != null)
            {
                countRow = tabMediaTableAdapter.InsertMedia(Title, Genre, Director, Language, PublishYear, Budget);
            }


            return countRow;

        }


        public List<Directors> getDirectors()
        {
            List<Directors> directors = new List<Directors>();

            var directorsTable = new UserData.TabDirectorDataTable();
            var directorsAdapater = new TabDirectorTableAdapter();

            int rowCount = directorsAdapater.getDirectors(directorsTable);
            if (rowCount > 0)
            {
                foreach (DataRow dr in directorsTable)
                {
                    Directors dir = new Directors();
                    dir.DID = int.Parse(dr["DID"].ToString());
                    dir.DirectorName = dr["DirectorName"].ToString();

                    directors.Add(dir);


                }


            }
            return directors;

        }


        public List<Genre> getGenre()
        {

            List<Genre> genres = new List<Genre>();

            var genreTable = new UserData.TabGenreDataTable();
            var genreAdapter = new TabGenreTableAdapter();

            int rowCount = genreAdapter.getGenre(genreTable);

            if (rowCount > 0)
            {
                foreach (DataRow dr in genreTable)
                {
                    Genre gen = new Genre();
                    gen.GID = int.Parse(dr["GID"].ToString());
                    gen.GenreName = dr["GenreName"].ToString();
                    genres.Add(gen);


                }
            }
            return genres;


        }


        public List<Language> getLanguage()


        {
            List<Language> languages = new List<Language>();

            var languageTable = new UserData.TabLanguageDataTable();

            var languageAdapter = new TabLanguageTableAdapter();

            int rowCount = languageAdapter.getLanguage(languageTable);


            if (rowCount > 0)
            {
                foreach (DataRow dr in languageTable)
                {
                    Language lan = new Language();

                    lan.LID = int.Parse(dr["LID"].ToString());
                    lan.LanguageName = dr["LanguageName"].ToString();
                    languages.Add(lan);
                }


            }
            return languages;


        }


        public int UpdateMedia(String Title, int Genre, int Director, int Language, int PublishYear, decimal Budget, int MediaID)
        {

            int rowCount = 0;
            if (Title != null)
            {
                rowCount = tabMediaTableAdapter.UpdateMedia(Title, Genre, Director, Language, PublishYear, Budget, MediaID);
            }


            return rowCount;
        }

        public int InsertGenre(String genreName)
        {
            var genreTable = new UserData.TabGenreDataTable();
            var genreAdapter = new TabGenreTableAdapter();
            int rowCount = 0;
            if (genreName != null)
            {
                rowCount = genreAdapter.InsertGenre(genreName);
                return rowCount;
            }
            return rowCount;
        }
        public int InsertLanguage(String languageName)
        {
            var languageTable = new UserData.TabLanguageDataTable();
            var languageAdapter = new TabLanguageTableAdapter();
            int rowCount = 0;
            if (languageName != null)
            {
                rowCount = languageAdapter.InsertLanguage(languageName);
                return rowCount;
            }
            return rowCount;
        }

        public int InsertDirector(String directorName)
        {
            var directorTable = new UserData.TabDirectorDataTable();
            var directorAdapter = new TabDirectorTableAdapter();
            int rowCount = 0;
            if (directorName != null)
            {
                rowCount = directorAdapter.InsertDirector(directorName);
                return rowCount;
            }
            return rowCount;
        }

        public int UpdateGenre(string genreName, int genreID)
        {
            var genreTable = new UserData.TabGenreDataTable();
            var genreAdapter = new TabGenreTableAdapter();
            int rowCount = 0;
            if (genreID != 0)
            {
                rowCount = genreAdapter.UpdateGenre(genreName, genreID);
                return rowCount;
            }
            return rowCount;


        }

        public int UpdateLanguage(string languageName, int languageID)
        {
            var languageTable = new UserData.TabLanguageDataTable();
            var languageAdapter = new TabLanguageTableAdapter();
            int rowCount = 0;
            if (languageID != 0)
            {
                rowCount = languageAdapter.UpdateLanguage(languageName, languageID);
                return rowCount;
            }
            return rowCount;

        }

        public int UpdateDirector(string directorName, int directorID)
        {
            var directorTable = new UserData.TabDirectorDataTable();
            var directorAdapter = new TabDirectorTableAdapter();
            int rowCount = 0;
            if (directorName != null)
            {
                rowCount = directorAdapter.UpdateDirector(directorName, directorID);
            }
            return rowCount;

        }

        public void DeleteGenre(int genreID)
        {
            var genreTable = new UserData.TabGenreDataTable();
            var genreAdapter = new TabGenreTableAdapter();
            int rowCount = genreAdapter.DeleteGenre(genreID);
        
        }

        public void DeleteLanguage(int languageID)
        {
            var languageTable = new UserData.TabLanguageDataTable();
            var languageAdapter = new TabLanguageTableAdapter();
            int rowCount = languageAdapter.DeleteLanguage(languageID);
            
        }

        public void DeleteDirector(int directorID)
        {
            var directorTable = new UserData.TabDirectorDataTable();
            var directorAdapter = new TabDirectorTableAdapter();
            int rowCount = directorAdapter.DeleteDirector(directorID);
        }

        public void DeleteMedia(int MediaID)
        {
            var mediaTable = new UserData.TabMediaDataTable();
            var mediaAdapter = new TabMediaTableAdapter();
            int rowCount = mediaAdapter.DeleteMedia(MediaID);
        }

        public List<MediaDataTransferObjects> viewMediaByValue(string value, string column)
        {
            List<MediaDataTransferObjects> allBooks = new List<MediaDataTransferObjects>();
            int rowCount = 0;
            if (column == "Title")
            {
                rowCount = tabMediaTableAdapter.TitleBrowse(tabMedias, value);
            }
            else if (column == "DirectorName")
            {
                rowCount = tabMediaTableAdapter.DirectorBrowse(tabMedias, value);
            }
            else if (column == "Genre")
            {
                rowCount = tabMediaTableAdapter.GenreBrowse(tabMedias, value);
            }
            else
            {
                rowCount = tabMediaTableAdapter.MediaView(tabMedias);
            }
            if (rowCount > 0)
            {

                foreach (DataRow r in tabMedias)
                {
                    MediaDataTransferObjects book = new MediaDataTransferObjects();
                    book.MediaID = int.Parse(r["MediaID"].ToString());
                    book.Title = r["Title"].ToString();
                    book.PublishYear = int.Parse(r["PublishYear"].ToString());
                    book.Language = r["LanguageName"].ToString();
                    book.Budget = decimal.Parse(r["Budget"].ToString());
                    book.Director = r["DirectorName"].ToString();
                    book.Genere = r["GenreName"].ToString();
                    allBooks.Add(book);
                }

            }
            return allBooks;
        }
    }
}
