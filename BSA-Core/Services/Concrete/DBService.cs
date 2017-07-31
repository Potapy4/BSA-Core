using BSACore.Models.Context;
using System.Threading.Tasks;

namespace BSACore.Services.Concrete
{
    public class DBService
    {
        private LogContext context;

        public DBService(LogContext context)
        {
            this.context = context;
        }

        public async Task LogInDB(Log log)
        {
            await context.Logs.AddAsync(log);
            await context.SaveChangesAsync();
        }
    }
}
