using IdentityServer4.Models;

namespace IdentityServer.Configurations;

public partial class Config
{
    public static IEnumerable<Client> Clients => new List<Client>
    {
        new()
        {
            ClientId = "MovieClient",
            AllowedGrantTypes = GrantTypes.ClientCredentials,
            ClientSecrets =
            {
                new Secret("secret".Sha256())
            },
            AllowedScopes =
            {
                "movieAPI"
            }
        }
    };
}
