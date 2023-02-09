using CashMachineApp.Domain.Entites;
using CashMachineApp.User_Interface;


namespace CashMachineApp.App
{
    class CashMachineApp
    {
        private List<UserAccounts> userAccountsList;
        private UserAccounts selectedAccount;
        public void InitalizeData()
        {
            userAccountsList = new List<UserAccounts>();
            {
                new UserAccounts { Id = 1, FullName = "Saed Farah", AccountNumber = 246810, CardNumber = 321321, CardPin = 7853, AccountBalance = 90000.00m, IsLocked = false };
                new UserAccounts { Id = 2, FullName = "Ali Mohammed", AccountNumber = 36912, CardNumber = 987987, CardPin = 2457, AccountBalance = 30000.00m, IsLocked = false };
            } new UserAccounts { Id = 3, FullName = "Yusuf Mahamed", AccountNumber = 481216, CardNumber = 783231, CardPin = 5718, AccountBalance = 60000.00m, IsLocked = false };

        }
        static void Main(string[] args)
        {
            Interface.Welcome();
            long cardNumber = Authenticate.Convert<long>(" your card number");
            Console.WriteLine($"your CardNumber is {cardNumber}");
        }
    }
}