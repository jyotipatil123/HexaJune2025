//// interface demo


//using System;

//namespace ConsoleApp_Hexaware
//{
//    interface IBank
//    {
//        void Deposit(double amount);        
//        void withdraw(double amount);
//    }

//    interface IBalance
//    {
//        double GetBalance();
//    }


//    class BankAccount : IBank, IBalance   // implment the interface 
//    {
//        double balance = 2000.000;

//        public void withdraw(double amount)    //implicit 
//        {
//            Console.WriteLine("withdraw is invoked ");
//        }

//        void IBank.Deposit(double amount)   //explicit implementation
//        {
//            Console.WriteLine("Depositing " + amount + " to the account.");
//        }

//         double IBalance.GetBalance()           //explicit implementation
//        {
//            Console.WriteLine("Please check the balance "+balance);
//            return balance;
//        }

//         void IBank.Withdraw(double amount)
//        {
//            Console.WriteLine("Withdraw the amount under a limit"+amount);
//        }
//    }


//    class interface_demo
//    {
//        static void Main(string[] args)
//        {
//                BankAccount obj = new BankAccount();
//            obj.withdraw(1000.00);  // implicit call to withdraw method
//            ((IBank)obj).Deposit(500.00);  // explicit call to Deposit method using interface

//            // explicit 
//            IBank bank=new BankAccount();
//            bank.Deposit(1000.00);  // explicit call to Deposit method using interface


//        }
//    }
//}
