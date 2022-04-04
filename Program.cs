using System;


abstract class Rbi
{
    int Bal = 0;

    public void Salogen()
    {

        Console.WriteLine("Reserve Bank of India");


    }

    public abstract int Deposit(int amount);
    public abstract int Withdraw(int amount);
    public abstract void GetBalance();


    class Bank : Rbi
    {



        public override int Deposit(int amount)
        {
            Console.WriteLine("Deposite amount is= {0}",amount);
            return amount;

        }
    public override int Withdraw(int amount)
    {

            Console.WriteLine("Withdrawl Amount ={0}",amount);
            return amount;
    ;    }
        public override void GetBalance()
        {
            Bal = Deposit(3000) - Withdraw(1000);
            Console.WriteLine("remaining balance in account is= "+Bal);
        }
        static void Main(string[] args)
        {

            Rbi obj = new Bank();
            
            
            obj.GetBalance();

            Console.ReadKey();

        }

    }
    




























}
