using System.Collections.Generic;
using System.Threading.Tasks;
using SocialSiteAPI.Models;

namespace SocialSiteAPI.Data
{
    public interface ISocialRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();

        Task<IEnumerable<User>> GetUsers();

        Task<User> GetUser(int id);
    }
}