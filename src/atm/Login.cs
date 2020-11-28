using System;
using System.Collections.Generic;

namespace atm
{
    public class Login 
    {
         private bool LoginStatus
         {
             set;
             get;
         }
      public Login()
      {    
 
      }
        CustomerDetails cust = new CustomerDetails();
        public bool LoginStatusMethod()
        {
            return LoginStatus;
        }

      public CustomerDetails GetStatus()
      {
            
            Console.WriteLine("total count    "+ cust.CustomerDetailsList.Count);
            foreach (var customer in cust.CustomerDetailsList)
            {
                          
            }    
        return null;
           
      }
    }
}