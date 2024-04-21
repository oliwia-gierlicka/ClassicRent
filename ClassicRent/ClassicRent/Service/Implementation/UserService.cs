using System.Security.Cryptography;
using System.Text;
using ClassicRent.Db;
using ClassicRent.Db.Entity;
using ClassicRent.Models;
using ClassicRent.Service.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ClassicRent.Service.Implementation;

public class UserService : IUserService
{
    private readonly ClassicRentDbContext _dbContext;
    private readonly ITokenProvider _tokenProvider;

    public UserService(ClassicRentDbContext dbContext, ITokenProvider tokenProvider)
    {
        _dbContext = dbContext;
        _tokenProvider = tokenProvider;
    }

    public async Task<TokenResponse?> Login(LoginForm form)
    {
        var hash = Convert.ToHexString(SHA256.HashData(Encoding.Default.GetBytes(form.Password)));
        var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Login == form.Login && hash == x.Password);

        if (user is not null)
            return new TokenResponse
            {
                Token = _tokenProvider.Generate(user),
                IsEmployee = user.IsEmployee
            };
        return null;
    }

    public async Task<bool> Register(RegisterForm form)
    {
        if (_dbContext.Users.Any(x => x.Login == form.Login))
        {
            return false;
        }

        _dbContext.Users.Add(new User
        {
            Name = form.Name,
            Surname = form.Surname,
            PhoneNumber = form.PhoneNumber,
            Mail = form.Mail,
            Login = form.Login,
            Password = Convert.ToHexString(SHA256.HashData(Encoding.Default.GetBytes(form.Password)))
        });
        await _dbContext.SaveChangesAsync();
        return true;
    }
}