namespace Day08_c_
{
    internal struct Account
    {
        // Private attributes
        private int accountId;
        private string accountHolder;
        private decimal balance;

        // Public properties (Encapsulation)
        public int AccountId
        {
            get { return accountId; }
            set
            {
                if (value > 0)
                    accountId = value;
                else
                    Console.WriteLine("AccountId must be positive.");
            }
        }

        public string AccountHolder
        {
            get { return accountHolder; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    accountHolder = value;
                else
                    Console.WriteLine("AccountHolder cannot be empty.");
            }
        }

        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                    balance = value;
                else
                    Console.WriteLine("Balance cannot be negative.");
            }
        }
        public Account(int id, string holder, decimal initialBalance)
        {
            accountId = 0;
            accountHolder = "";
            balance = 0;

            AccountId = id;
            AccountHolder = holder;
            Balance = initialBalance;
        }
        public void DisplayAccount()
        {
            Console.WriteLine($"Account ID: {AccountId}, Holder: {AccountHolder}, Balance: {Balance:C}");
        }
    }
}
