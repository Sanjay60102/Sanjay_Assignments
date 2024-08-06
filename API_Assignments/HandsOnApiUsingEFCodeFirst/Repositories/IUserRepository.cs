using HandsOnApiUsingEFCodeFirst.Entities;
using System.Security.Cryptography;

namespace HandsOnApiUsingEFCodeFirst.Repositories
{
    public interface IUserRepository
    {
        void Register(User user);
        User ValidUser(string email, string password);
    }
}
