using ClassicRent.Models;

namespace ClassicRent.Service.Abstract;

public interface IUserService
{
    Task<TokenResponse?> Login(LoginForm form);
    Task<bool> Register(RegisterForm form);
}