namespace Account
{
    class Account
    {
        private string _name;
        private double _money;

        public Account(string name, double money)
        {
            _name = name;
            _money = money;
        }

        public double Withdrawal(double amount)
        {
            _money -= amount;
            return amount;
        }

        public void Deposit(double amount)
        {
            _money += amount;
        }

        public double Balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}