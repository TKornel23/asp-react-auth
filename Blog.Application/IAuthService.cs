using Blog.Model;

namespace Blog.Application
{
    public interface IAuthService
    {
        AuthData GetAuthData(string id);
        string HashPassword(string password);
        bool VerifyPassword(string actualPassword, string hashedPassword);
    }
}