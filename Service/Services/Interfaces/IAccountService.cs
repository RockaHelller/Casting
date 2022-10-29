using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interfaces
{
    interface IAccountService
    {
        string Login(string email, string password, int role);

    }
}
