using IdentityServer4.Models;
using IdentityServer4.Test;

namespace IdentityServer.Configurations;

public class Config
{
    public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope> { new("movieAPI", "Movie API") };

    public static IEnumerable<Client> Clients => new List<Client>
    {
        new()
        {
            ClientId = "MovieClient",
            AllowedGrantTypes = GrantTypes.ClientCredentials,
            ClientSecrets = { new Secret("secret".Sha256()) },
            AllowedScopes = { "movieAPI" }
        }
    };

    public static IEnumerable<ApiResource> ApiResources => Array.Empty<ApiResource>();
    public static IEnumerable<IdentityResource> IdentityResources => Array.Empty<IdentityResource>();
    public static List<TestUser> TestUsers => new();
}
