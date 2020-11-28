using System;

namespace atm
{
    class ATM
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n\n\nWelcome to innRoad Bank");
            String entrace = "yes";      
            CustomerDetails NewCustomer = new CustomerDetails();
            while(entrace.Equals("yes"))
            {
                Console.WriteLine("1. Sign Up       2. Sign in");
                bool LoginStatus = false;
                int choice = Convert.ToInt16(Console.ReadLine());
                switch(choice)
                {
                    
                    case 1: NewCustomer.setCustomerDetails();
                            break;
                    case 2: Console.WriteLine("Enter Account Number");
                            long account = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Enter pin");
                            int pin = Convert.ToInt16(Console.ReadLine());
                            foreach (var customer in NewCustomer.CustomerDetailsList)
                            {
                                
                                if ( customer.AccountNumber == account && customer.Pin == pin )
                                {
                                    LoginStatus = true;   
                                    Console.WriteLine("1. Deposite           2. Withdraw           3. Check Balanace        4.exit");
                                    int finalStatus = Convert.ToInt16(Console.ReadLine());   
                                    AtmOperations operation = new AtmOperations(ref NewCustomer);
                                    if(finalStatus!=4)
                                    {    
                                        switch(finalStatus)
                                        {
                                            
                                            case 1: Console.WriteLine("Enter amount to deposite");
                                                    long amount = Convert.ToInt64(Console.ReadLine());
                                                    operation.Deposit(amount);
                                                    break;
                                            case 2: Console.WriteLine("Enter amount to withdraw");
                                                    amount = Convert.ToInt64(Console.ReadLine());
                                                    operation.Withdrawl(amount);
                                                    break;
                                            case 3: long RemainingAmount = operation.CheckBalance();
                                                    Console.WriteLine($"Your Balance = {RemainingAmount}");
                                                    break;
                                            case 4: break;
                                        }

                                    }          
                                }   
                            } 
                            if(LoginStatus)
                            {
                                Console.WriteLine("you are Logged out");
                            }
                            else
                              Console.WriteLine("Sorry you are not registered  ");
                            break;
                    default:  break;
    
                }
                    Console.WriteLine("To run application, please type 'yes'  ");
                    entrace = (Console.ReadLine());
             
            }
        }
    }
}

