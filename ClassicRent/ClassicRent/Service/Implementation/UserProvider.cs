using ClassicRent.Service.Abstract;

namespace ClassicRent.Service.Implementation;

public class UserProvider : IUserProvider
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public UserProvider(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public int GetUserId()
    {
        return int.Parse(_httpContextAccessor.HttpContext?.User?.Claims?.FirstOrDefault(x => x.Type=="name")?.Value ?? "-1");
    }
}