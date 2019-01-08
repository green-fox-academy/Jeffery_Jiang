using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxCoinProject.Models;

namespace FoxCoinProject.Services
{
    public interface IBankAccountServer
    {
        Task<IEnumerable<UserAccount>> FindAllAccounts();
        Task<UserAccount> FindById(long userId);
        Task GenerateCoin(long userId);
    }
}
