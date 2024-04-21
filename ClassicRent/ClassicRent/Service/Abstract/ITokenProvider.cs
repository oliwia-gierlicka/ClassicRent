using ClassicRent.Db.Entity;

namespace ClassicRent.Service.Abstract;

public interface ITokenProvider
{
    string Generate(User user);
}