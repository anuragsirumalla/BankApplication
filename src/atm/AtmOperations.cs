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
           customer.balance = customer.balance - amount;
           Console.WriteLine($"your amount {amount} succesfully withdraw");
            return customer.balance;
        }

        public void Deposit(long amount)
        {
           customer.balance = customer.balance + amount;
           Console.WriteLine($"your amount {amount} succesfully deposited");
        }

        public long CheckBalance()
        {
             return customer.balance;
        }
    }
}