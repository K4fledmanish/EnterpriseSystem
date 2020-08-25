using ModelLayer;
using ModelLayer.UserDataTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using static MediaLibraryWFC.DataTransferObjects;

namespace MediaLibraryWFC
{
    
    public class UserManagerImpl : UserManagement

    {
        UserData.TabUserDataTable userTable = new UserData.TabUserDataTable();
        TabUserTableAdapter userAdapter = new TabUserTableAdapter();

        UserData.TabMediaDataTable mediaTable = new UserData.TabMediaDataTable();
        TabMediaTableAdapter mediaAdapter = new TabMediaTableAdapter();




        public List<User> userVerify(string userName, string password)
        {
            User newUser = new User();
            var userData = new UserData.TabUserDataTable();
            var userTableAdapter = new TabUserTableAdapter();
            List<User> userValue = new List<User>();
            int rowCount = 0;
            if (userName != null && password != null)
            {

                rowCount = userTableAdapter.ValidateUsers(userData, userName, password);
            }
            if (rowCount > 0)
            {
                foreach (DataRow dr in userData.Rows)
                {
                    newUser.UID = int.Parse(dr["UID"].ToString());

                    newUser.userEmail = dr["UserEmail"].ToString();
                    newUser.userLevel = int.Parse(dr["UserLevel"].ToString());
                    userValue.Add(newUser);
                }
                return userValue;
            }
            return null;

        }

        List<User> UserManagement.getUsers()
        {
            List<User> users = new List<User>();

            var userData = new UserData.TabUserDataTable();
            var userDataAdapter = new TabUserTableAdapter();

            userDataAdapter.GetUsersBy(userData);

            foreach (DataRow dr in userData.Rows)
            {
                User newUser = new User();
                newUser.UID = int.Parse(dr["UID"].ToString());
                newUser.userName = dr["UserName"].ToString();
                newUser.password = dr["Password"].ToString();
                newUser.userEmail = dr["UserEmail"].ToString();
                newUser.userLevel = int.Parse(dr["UserLevel"].ToString());
                users.Add(newUser);
            }

            return users;
        }

        public int InsertUser(string userName, string userEmail, int userLevel, string password)
        {

            var userData = new UserData.TabUserDataTable();
            var userTableAdapter = new TabUserTableAdapter();

            if (userName != null && password != null)
            {
                int countRow = userTableAdapter.InsertUser(userName, password, userLevel, userEmail);
                return countRow;
            }
            else
            {
                return 0;
            }


        }

        public int UpdateUser(int UID, string userName, string userEmail, int userLevel, string password)
        {

            var userData = new UserData.TabUserDataTable();
            var userTableAdapter = new TabUserTableAdapter();
            if (UID > 0)
            {

                int countRow = userTableAdapter.UpdateUser(userName, password, userLevel, userEmail, UID);

                return countRow;
            }
            return 0;
        }

        public void DeleteUser(int UID)
        {
            var userData = new UserData.TabUserDataTable();
            var userTableAdapter = new TabUserTableAdapter();
            int countRow = userTableAdapter.DeleteUser(UID);

        }


        public void InsertBorrow(int UID, int MediaID, string borrowDate, string returnDate)
        {

            var borrowTable = new UserData.TabBorrowDataTable();
            var borrowAdapter = new TabBorrowTableAdapter();

            int countRow = borrowAdapter.InsertBorrow(UID, MediaID, borrowDate, returnDate);
            countRow = mediaAdapter.UpdateBorrow(MediaID);


        }

        public void InsertReserve(int UID, int MID, string date)
        {
            var reserveTable = new UserData.TabReservedDataTable();
            var reserveAdapter = new TabReservedTableAdapter();


            List<Reserve> reserves = new List<Reserve>();

            reserveAdapter.InsertReserve(UID, MID, date);

        }

        public List<ReserveDTO> GetReserves()
        {
            var reserveTable = new UserData.TabReservedDataTable();
            var reserveAdapter = new TabReservedTableAdapter();
            List<ReserveDTO> reserveList = new List<ReserveDTO>();
            int rowCount = reserveAdapter.getReserve(reserveTable);
            if (rowCount > 0)
            {
                foreach (DataRow r in reserveTable.Rows)
                {
                    ReserveDTO reserve = new ReserveDTO();
                    reserve.RID = int.Parse(r["RID"].ToString());
                    reserve.UserName = r["UserName"].ToString();
                    reserve.Title = r["Title"].ToString();
                    reserve.ReservedDate = r["ReservedDate"].ToString();
                    reserveList.Add(reserve);
                }
            }
            return reserveList;
        }

        public List<Borrow> GetBorrows(int UID)
        {
            var borrowTable = new UserData.TabBorrowDataTable();
            var borrowAdapter = new TabBorrowTableAdapter();
            List<Borrow> list = new List<Borrow>();
            int rowCount = borrowAdapter.GetBorrows(borrowTable);
            if (rowCount > 0)
            {
                foreach (DataRow r in borrowTable)
                {
                    Borrow borrow = new Borrow();
                    borrow.BID = int.Parse(r["BID"].ToString());
                    borrow.MediaID = int.Parse(r["MediaID"].ToString());
                    borrow.BorrowDate = r["BorrowDate"].ToString();
                    borrow.ReturnDate = r["ReturnDate"].ToString();
                    borrow.ActualReturnDate = r["ActualReturnDate"].ToString();

                    borrow.LateFee = decimal.Parse(r["LateFee"].ToString());
                    list.Add(borrow);
                }
            }
            return list;

        }

        public List<Borrow> AllBorrows()


        {
            var borrowTable = new UserData.TabBorrowDataTable();
            var borrowAdapter = new TabBorrowTableAdapter();
            List<Borrow> list = new List<Borrow>();
            int rowCount = borrowAdapter.GetBorrows(borrowTable);
            if (rowCount > 0)
            {
                foreach (DataRow r in borrowTable)
                {
                    Borrow borrow = new Borrow();
                    borrow.BID = int.Parse(r["BID"].ToString());
                    borrow.MediaID = int.Parse(r["MediaID"].ToString());
                    borrow.BorrowDate = r["BorrowDate"].ToString();
                    borrow.ReturnDate = r["ReturnDate"].ToString();
                    borrow.ActualReturnDate = r["ActualReturnDate"].ToString();
                    borrow.BStatus = r["BStatus"].ToString();
                    borrow.LateFee = decimal.Parse(r["LateFee"].ToString());
                    list.Add(borrow);
                }
            }
            return list;


        }

        public void InsertReturn(string actualReturnDate, decimal lateFee, int BID, int MID)
        {
            var borrowTable = new UserData.TabBorrowDataTable();
            var borrowAdapter = new TabBorrowTableAdapter();
            int rowCount = borrowAdapter.ReturnUpdate(actualReturnDate, lateFee, BID);
            rowCount = mediaAdapter.UpdateReturn(MID);

        }
    }
}
