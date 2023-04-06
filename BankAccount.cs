//Jisselle Garcia, 04/02/23
//Bank Account Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6JG
{
    public enum accountStatus { Ok, Overdrawn, InsufficientFunds, DepositMax }

    public class BankAccount
    {
        //private field
        private decimal _accountBalance;

        //setting a public property to set in constructor method
        public string AccountNumber { get; }

        // public property with a private setter. Constructor that defines property of class. 
        public List<decimal> AccountBalances { get; private set; }
        public BankAccount(decimal AccountBalance, string AccountNumber)
        {
            _accountBalance = AccountBalance;
            this.AccountNumber = AccountNumber;

            AccountBalances = new List<decimal>();
            AccountBalances.Add(_accountBalance); //Adding to starting account balance
        }

        public accountStatus Deposit(decimal depositAmount)
        {
            if (depositAmount > 10_000)
                return accountStatus.DepositMax;

            _accountBalance += depositAmount;
            AccountBalances.Add(_accountBalance);

            return accountStatus.Ok;
        }

        //calling accountbalances list, Withdrawl m stands for "money"
        public accountStatus Withdrawal(decimal withdrawalAmount)
        {
            if (_accountBalance < 0 || _accountBalance - withdrawalAmount < -100)
                return accountStatus.InsufficientFunds;

            _accountBalance -= withdrawalAmount;
            AccountBalances.Add(_accountBalance);

            if (_accountBalance < 0)
            {
                _accountBalance -= 35.75m;
                AccountBalances.Add(_accountBalance);
                return accountStatus.Overdrawn;
            }
            return accountStatus.Ok;
        }

        public accountStatus GetAccountStatus()
        {
            if (_accountBalance >= 0)
                return accountStatus.Ok;
            else
                return accountStatus.Overdrawn;
        }

        public decimal GetAccountBalance()
        {
            return _accountBalance;
        }

    }
}