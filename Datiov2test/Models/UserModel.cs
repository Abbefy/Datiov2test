namespace Datiov2test.Models
{
    public class UserModel
    {
        //public UserModel()
        //{

        //}

        //public UserModel(int userID, string userName, string userFirstName, string userLastName, string userPass, string userEmail, int userType) 
        //{
        //    UserID = userID;
        //    UserName = userName;
        //    UserFirstName = userFirstName;
        //    UserLastName = userLastName;
        //    UserPass = userPass;
        //    UserEmail = userEmail;
        //    UserType = userType;
        //}

        public UserModel()
        {

        }

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserPass { get; set; }
        public string UserEmail { get; set; }
        public int UserType { get; set; }

    }
}
