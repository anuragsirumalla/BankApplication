namespace atm
{


    public interface IAtm
    {

        public abstract double Withdrawl(long amount);
        public abstract void Deposit(long amount);
        public abstract long CheckBalance();
    }
}