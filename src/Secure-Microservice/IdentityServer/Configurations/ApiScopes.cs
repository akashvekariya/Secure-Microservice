using IdentityServer4.Models;

namespace IdentityServer.Configurations;

public partial class Config
{
    public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope>
    {
        new("movieAPI", "Movie API")
    };
}
