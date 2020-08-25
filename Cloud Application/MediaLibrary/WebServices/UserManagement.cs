using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using static MediaLibraryWFC.DataTransferObjects;

namespace MediaLibraryWFC
{
    public interface UserManagement
    {
        [OperationContract]
        List<User> userVerify(string userName, string Password);

        [OperationContract]
        List<User> getUsers();

        [OperationContract]
        int InsertUser(string userName, string userEmail, int userLevel, string password);


        [OperationContract]
        int UpdateUser(int UID, string userName, string userEmail, int userLevel, string password);

        [OperationContract]
        void DeleteUser(int UID);

        [OperationContract]
        void InsertBorrow(int UID, int MediaID, string borrowDate, string returnDate);

        [OperationContract]
        List<Borrow> GetBorrows(int UID);

        [OperationContract]
        List<Borrow> AllBorrows();

        [OperationContract]
        void InsertReserve(int UID, int MID, string date);

        [OperationContract]
        void InsertReturn(string actualReturnDate, decimal lateFee, int BID, int MID);

        [OperationContract]
        List<ReserveDTO> GetReserves();

    }
}