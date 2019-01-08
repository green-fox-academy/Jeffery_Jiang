using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxCoinProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FoxCoinProject.Services
{
    public class BankAccountServer : IBankAccountServer
    {
        private readonly FoxBankContext foxBankContext;

        public BankAccountServer(FoxBankContext foxBankContext)
        {
            this.foxBankContext = foxBankContext;
        }

        public async Task<IEnumerable<UserAccount>> FindAllAccounts()
        {
            return await foxBankContext.UserAccounts.ToListAsync();

        }

        public async Task<UserAccount> FindById(long userId)
        {
            return await foxBankContext.UserAccounts.FindAsync(userId);
        }

        public async Task GenerateCoin(long userId)
        {
            var user= await foxBankContext.UserAccounts.FindAsync(userId);
            user.Balance++;
            await foxBankContext.SaveChangesAsync();
        }
    }
}
