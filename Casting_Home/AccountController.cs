using Service.Services;
using System;
using System.Collections.Generic;
using System.Text;
using static Service.Services.AccountService;
using AccountService = Service.Services.AccountService;

namespace Casting_Home
{
    public class AccountController
    {
        public void Login()
        {
            Console.WriteLine("Add email:");
            string email = Console.ReadLine();

            Console.WriteLine("Add password");

            string password = Console.ReadLine();

            int role = 1;

            AccountService account = new AccountService();

            var result = account.Login(email, password, role);

            Console.WriteLine(result);
        }
    }
}
