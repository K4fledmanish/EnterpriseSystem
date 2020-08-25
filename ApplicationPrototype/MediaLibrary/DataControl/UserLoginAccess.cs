using DataModel.UserMediaDataTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataControl
{ 
    public class UserLoginAccess : IUserValidation
    {
        public bool UserValidate(string username, string password)
        {
            bool accessUser = false;

            try // Using try and catch statement to find error if there is any.
            {
                // Connecting to a Database(UserMediaData) table 
                TabUserTableAdapter tabUserTableAdapter = new TabUserTableAdapter(); 

                int loginStatus = (int)tabUserTableAdapter.LoginQuery(username, password); //Using Custome made query

                if (loginStatus == 1)
                {
                    accessUser = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Database Error" + e.Message); // Error Message
            }
            return accessUser;
        }
    }
}
