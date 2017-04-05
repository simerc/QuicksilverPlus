using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quicksilver.Business.Services
{
    public class AccountService
    {
        public async Task OnUserAccountCreated(object sender, EventArgs e)
        {
            await Task.Delay(1000);
        }

        public AccountService()
        {
            
        }


        public bool CreateUserAccount()
        {
            Console.WriteLine("Creating user account");
            Thread.Sleep(3000);

            Console.WriteLine("UserAccount created");

            OnUserAccountCreated(this, new EventArgs());




            return true;
        }

    }
}
