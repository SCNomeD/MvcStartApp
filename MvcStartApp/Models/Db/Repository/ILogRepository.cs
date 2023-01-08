using System.Threading.Tasks;

namespace MvcStartApp.Models.Db.Repository
{
    public interface ILogRepository
    {
        Task AddRequest(Request request);
        Task<Request[]> GetLogs();
    }
}
