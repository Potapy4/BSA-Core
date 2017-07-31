using BSACore.Models.RandomUser;
using System.Threading.Tasks;

namespace BSACore.Services.Interfaces
{
    public interface IRandomUserProvider
    {
        Task<UserData> GetRandomUser();
    }
}
