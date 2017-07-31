using BSACore.Services.Interfaces;
using System.Threading.Tasks;
using BSACore.Models.RandomUser;
using System.Net.Http;
using Newtonsoft.Json;

namespace BSACore.Services.Concrete
{
    public class RandomUserService : IRandomUserProvider
    {
        private readonly string api = "https://randomuser.me/api";

        public async Task<UserData> GetRandomUser()
        {
            string json = null;

            using (var client = new HttpClient())
            {
                json = await client.GetStringAsync(api);
            }

            return JsonConvert.DeserializeObject<UserData>(json);
        }
    }
}
