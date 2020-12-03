using System;
using System.Collections.Generic;

namespace atm
{
    public class Login
    {
        private long Account
        {
            set;
            get;
        }
        private int Password
        {
            set;
            get;
        }
        private bool LoginStatus
        {
            set;
            get;
        }
        public Login()
        {
            LoginStatus = false;
        }

        public bool LoginStatusMethod()
        {
            return LoginStatus;
        }
        void GetLoginCustomerDetails()
        {
            Console.Write("Enter Account Number : ");
            Account = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter pin : ");
            Password = Convert.ToInt16(Console.ReadLine());
        }
        public CustomerDetails GetStatus(ref CustomerDetails Customer)
        {
            GetLoginCustomerDetails();
            foreach (var LoginCustomer in Customer.CustomerDetailsList)
            {
                if (LoginCustomer.AccountNumber == Account && LoginCustomer.Pin == Password)
                {
                    Console.WriteLine($"Login Success");
                    LoginStatus = true;
                    return LoginCustomer;
                }
            }
            return null;
        }
    }

}