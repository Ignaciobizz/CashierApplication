using System;

namespace UserAccountNamespace
{
    public class UserAccount
    {
        protected string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name,
                           string username,
                           string password)
        {
            full_name = name;
            user_name = username;
            user_password = password;
        }

        public virtual bool validateLogin(string username,
                                          string password)
        {
            return user_name == username &&
                   user_password == password;
        }

        public virtual string getFullName()
        {
            return full_name;
        }
    }
}