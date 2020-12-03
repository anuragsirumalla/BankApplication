using System;

namespace atm
{
    class CustomerTransaction
    {
        public CustomerTransaction(ref CustomerDetails LoginCustomer)
        {
            Console.WriteLine($"\nHello! {LoginCustomer.Name} ");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("| 1. Deposite     |     2. Withdraw      |     3. Check Balanace     |    4.exit |");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.Write("please choose your choice : ");
            int finalStatus = 0;
            try
            {
                finalStatus = Convert.ToInt16(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.Write("Invalid choice");
            }
            AtmOperations operation = new AtmOperations(ref LoginCustomer);
            if (finalStatus != 4)
            {
                try
                {
                    switch (finalStatus)
                    {
                        case 1:
                            Console.Write("Enter amount to deposite : ");
                            long amount = Convert.ToInt64(Console.ReadLine());
                            operation.Deposit(amount);
                            break;
                        case 2:
                            Console.Write("Enter amount to withdraw : ");
                            amount = Convert.ToInt64(Console.ReadLine());
                            if (amount > 0)
                                operation.Withdrawl(amount);
                            break;
                        case 3:
                            long RemainingAmount = operation.CheckBalance();
                            Console.WriteLine($"Your Balance = {RemainingAmount}");
                            break;
                        case 4: break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Invalid Amount");
                }
            }
        }
    }
}