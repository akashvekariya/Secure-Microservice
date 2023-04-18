using IdentityServer4.Models;
using IdentityServer4.Test;

namespace IdentityServer.Configurations;

public class Config
{
    public static IEnumerable<Client> Clients => Array.Empty<Client>();
    public static IEnumerable<ApiResource> ApiResources => Array.Empty<ApiResource>();
    public static IEnumerable<ApiScope> ApiScopes => Array.Empty<ApiScope>();
    public static IEnumerable<IdentityResource> IdentityResources => Array.Empty<IdentityResource>();
    public static List<TestUser> TestUsers => new();
}
