using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccApp
{
    public class SavingsAccount: BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string owner, decimal interestRate) : base(owner + " ("+interestRate+"%)")
        {
            InterestRate= interestRate;
        }
        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You can not deposit " + amount;
            if (amount > 50000)
                return "You can not deposit more than 50000 at once";
            decimal interestAmount = amount * (InterestRate / 100);
            Balance += amount + interestAmount;
            return $"You have successfully deposited {amount}.";
        }
    }
}
