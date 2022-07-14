using Manager.Domain.Entities;

namespace Manager.Infra.Interfaces
{
    public class IUserRepository : IBaseRepository<User>
    {
        Task<User> GetByEmail(string email);
        Task<List<User>> SearchByEmail(string email);
        Task<List<User>> SearchByName(string email);

    }
}
