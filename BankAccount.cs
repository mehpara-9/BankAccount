using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        private decimal _balance;
        public decimal Balance { get; }

        public BankAccount(decimal Balance)
        {
            if (Balance > 0)
            {
                _balance = Balance;
            }
        }
    
    public string Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return "Deposit meblegi 0-dan kicik ola bilmez";
            }
            _balance 
        }


    

    
    
}
