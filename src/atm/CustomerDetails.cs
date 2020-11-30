using System;
using System.Collections.Generic;

namespace atm
{
    public class CustomerDetails
    {
        public long AccountNumber
        {
            get;
            set;
        }
        public int Pin
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public long balance
        {
            get;
            set;
        }
        public CustomerDetails()
        {
            CustomerDetailsList = new List<CustomerDetails>();
        }
        public CustomerDetails(long AccountNumber, int pin, string Name)
        {
            balance = 0;
            this.AccountNumber = AccountNumber;
            this.Pin = pin;
            this.Name = Name;
        }
        public void setCustomerDetails()
        {
            Console.Write("Hello! Please your Details");
            Console.Write("\nEnter your name : ");
            Name = Console.ReadLine();
            Console.Write("Account Number : ");
            AccountNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Pin : ");
            Pin = Convert.ToInt16(Console.ReadLine());
            CustomerDetailsList.Add(new CustomerDetails(AccountNumber, Pin, Name));
            Console.WriteLine("Your Details Succesfully added ");
        }
        public void ShowCustomer()
        {
            foreach (var customer in CustomerDetailsList)
            {
                Console.WriteLine(customer.AccountNumber + "    " + customer.Pin);
            }
        }
        public List<CustomerDetails> CustomerDetailsList;
    }
}