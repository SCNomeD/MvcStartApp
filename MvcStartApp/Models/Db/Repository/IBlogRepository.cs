using System.Threading.Tasks;

namespace MvcStartApp.Models.Db.Repository
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
        Task<User[]> GetUsers();
    }
}
