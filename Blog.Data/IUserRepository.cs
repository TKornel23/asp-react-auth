using Blog.Model;

namespace Blog.Data
{
    public interface IUserRepository : IEntityBaseRepository<User>
    {
        bool isEmailUniq(string email);
        bool IsUsernameUniq(string username);
    }
}