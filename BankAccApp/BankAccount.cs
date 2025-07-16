using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccApp
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public long AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        private static Random random = new Random(); // Shared Random instance

        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Generate10DigitNumber();
            Balance = 0;
        }

        private long Generate10DigitNumber()
        {
            return random.NextInt64(1000000000L, 9999999999L); //
        }
        public virtual string Deposit (decimal amount)
        {
            if (amount <= 0)
                return "You can not deposit "+amount;
            if (amount > 50000)
                return "You can not deposit more than 50000 at once";
            Balance += amount;
            return "Deposit successfully completed.";
        }

        public string Withdraw (decimal amount)
        {
            if (amount <= 0)
                return "You can not withdraw " + amount;
            if (amount > Balance)
                return "Insufficient balance";
            Balance -= amount;
            return "Withdraw successfully completed.";
        }
    }
}
