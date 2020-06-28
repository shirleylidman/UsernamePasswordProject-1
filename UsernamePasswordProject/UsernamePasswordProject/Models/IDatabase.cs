using System.Collections.Generic;
using System.Threading.Tasks;

namespace UsernamePasswordProject.Models
{
    public interface IDatabase
    {
        Task<List<Account>> GetAccountsAsync();
        Task<int> SaveAccountAsync(Account account);
    }
}
