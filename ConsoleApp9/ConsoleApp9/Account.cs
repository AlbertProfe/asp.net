using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    public class Account
    {
        public String idAccount;
        public double balance;
        public String bank;
        public String currency;

        public Account() { }

        public Account(string idAccount, double balance, string bank, string currency)
        {

            this.idAccount = idAccount;
            this.bank = bank;
            this.currency = currency;

            // because balance cant be negative
            if (balance > 0) this.balance = balance;
            else this.balance = 0;

        }

        public override string ToString()
        {

            return "[Account values] IdAccount " + idAccount + " Balance: " + balance +
                " Bank: " + bank + " Currency: " + currency;
        }

        public bool WithDraw(double amount)
        {
            //Console.WriteLine("entra en wd");

            if (amount > this.balance)
            {
                return false;
            }
            else
            {
                //make with
                //Console.WriteLine("pre operacion" + balance + amount);
                this.balance = this.balance - amount;
                //Console.WriteLine("sale de wd" + balance + amount);
                return true;
            }


        }

        public bool Deposit(double moneyToDeposit)
        {

            if (moneyToDeposit <= 0)
                return false;
            else
            {
                this.balance = this.balance + moneyToDeposit;
                return true;
            }
        }

        public bool Transfer(Account accountToTransfer, double moneyTotransfer)
        {
            if (moneyTotransfer > balance)
                return false;

            else
            {
                WithDraw(moneyTotransfer);
                accountToTransfer.Deposit(moneyTotransfer);
                return true;
            }

        }

        public bool Transfer(Person fromPerson, Person toPerson, double moneyTotransfer) {


            if (moneyTotransfer > balance)
                return false;

            else
            {
                fromPerson.account.WithDraw(moneyTotransfer);
                toPerson.account.Deposit(moneyTotransfer);
                return true;
            }

        }

        public double Balance
        {
            get { return Balance; }
            set { Balance = value; }
        }

        public String Bank
        {
            get { return Bank; }
            set { Bank = value; }
        }

        public String Currency
        {
            get { return Currency; }
            set { Currency = value; }
        }

    }
}
