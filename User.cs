using System;
namespace HotelBooking
{
    class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string mobileNumber { get; set; }
        public string gmail { get; set; }
        public string password { get; set; }
        public string userType { get; set; }
        public User(string firstName, string lastName, string mobileNumber, string gmail, string password, string userType)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.mobileNumber = mobileNumber;
            this.gmail = gmail;
            this.password = password;
            this.userType = userType;
        }
        public User(string gmail, string password)
        {
            this.gmail = gmail;
            this.password = password;
        }
        public override string ToString()
        {
            Console.WriteLine("User Name is                        : {0}", firstName);
            Console.WriteLine("Mobile number is                    : {0}", mobileNumber);
            Console.WriteLine("Password is                         : {0}", password);
            return "";
        }
    }
}
