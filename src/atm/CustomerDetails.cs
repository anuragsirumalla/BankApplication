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
         private string Name
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
                foreach (var item in CustomerDetailsList)
                {
                    Console.WriteLine("{item.AccountNumber}  ----->   {item.Pin}");
                }
        }
        public CustomerDetails(long AccountNumber, int pin)
        {
            balance = 0;
            this.AccountNumber = AccountNumber;
            this.Pin = pin;
            Console.WriteLine("Succesfully added");
        }
           public void setCustomerDetails()
            {
            Console.WriteLine("Enter customer Details");
            Console.WriteLine("Enter Account Number");
            AccountNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter pin");
            Pin = Convert.ToInt16(Console.ReadLine());
             CustomerDetailsList.Add(new CustomerDetails(AccountNumber,Pin));
             Console.WriteLine($"customers details {CustomerDetailsList.Count}");
            }
            public void ShowCustomer()
            {
                foreach (var customer in CustomerDetailsList)
            {
                Console.WriteLine(customer.AccountNumber +"    "+ customer.Pin);          
            }    
            }
        public List<CustomerDetails> CustomerDetailsList = new List<CustomerDetails>();
    }
}