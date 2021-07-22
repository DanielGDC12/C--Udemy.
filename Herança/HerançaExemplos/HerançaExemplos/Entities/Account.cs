namespace HerançaExemplos.Entities
{
    class Account
    {

        public string Holder { get; protected set; } //Protected forma de proteger atribuições de fora do assembly ,podendo ser apenas alterada por ela mesma ou por classes herdadas
        public double  Balance { get;  protected set; }
        public int ID { get; protected set; }

        public Account()
        {

        }

        public Account(string holder, double balance, int iD)
        {
            Holder = holder;
            Balance = balance;
            ID = iD;
        }


        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
