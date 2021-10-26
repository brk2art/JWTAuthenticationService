using JWTAuthenticationDemo.Core.Configuration;
using JWTAuthenticationDemo.Core.DTOs;
using JWTAuthenticationDemo.Core.Models;

namespace JWTAuthenticationDemo.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);
        ClientTokenDto CreateTokenByClient(Client client);
    }
}
