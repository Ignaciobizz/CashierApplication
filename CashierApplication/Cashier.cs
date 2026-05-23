using System;

namespace UserAccountNamespace
{
    public class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name,
                       string departmentName,
                       string username,
                       string password)
            : base(name, username, password)
        {
            department = departmentName;
        }

        public override bool validateLogin(string username,
                                           string password)
        {
            return base.validateLogin(username, password);
        }

        public string getDepartment()
        {
            return department;
        }
    }
}