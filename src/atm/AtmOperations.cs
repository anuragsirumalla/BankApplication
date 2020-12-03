using System;

namespace atm
{
    public class AtmOperations : IAtm
    {

        CustomerDetails customer;
        public AtmOperations(ref CustomerDetails customer)
        {
            this.customer = customer;
        }
        public double Withdrawl(long amount)
        {
            if (customer.balance < amount)
                Console.WriteLine($"you have in-sufficient balance");
            else
            {
                customer.balance = customer.balance - amount;
                Console.WriteLine($"your amount {amount} succesfully withdraw");
                return customer.balance;
            }
            return 0;
        }

        public  void Deposit(long amount)
        {
            customer.balance = customer.balance + amount;
            Console.WriteLine($"your amount {amount} succesfully deposited\n");
        }

        public  long CheckBalance()
        {
            return customer.balance;
        }
    }
}