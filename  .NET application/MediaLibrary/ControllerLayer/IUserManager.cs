using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ControllerLayer.DTOCollection;

namespace ControllerLayer
{
   public interface IUserManager
    {
        List<User> userVerify(string userName, string Password);

        List<User> getUsers();

         int InsertUser(string userName, string userEmail, int userLevel, string password);

        int UpdateUser(int UID,string userName, string userEmail, int userLevel, string password);

        void DeleteUser(int UID);

        void InsertBorrow(int UID, int MediaID, string borrowDate, string returnDate);

        List<Borrow> GetBorrows(int UID);

        List<Borrow> AllBorrows();

        void InsertReserve(int UID, int MID, string date);

        void InsertReturn(string actualReturnDate, decimal lateFee, int BID, int MID);

        List<ReserveDTO> GetReserves();
    }
}
