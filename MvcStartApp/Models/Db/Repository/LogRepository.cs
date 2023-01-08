using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MvcStartApp.Models.Db.Repository
{
    public class LogRepository : ILogRepository
    {
        private readonly BlogContext _context;

        public LogRepository(BlogContext context)
        {
            _context = context;
        }
        public async Task AddRequest(Request request)
        {
            var entry = _context.Entry(request);
            if (entry.State == EntityState.Detached)
            {
                await _context.Requests.AddAsync(request);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Request[]> GetLogs()
        {
            return await _context.Requests.ToArrayAsync();
        }
    }
}
