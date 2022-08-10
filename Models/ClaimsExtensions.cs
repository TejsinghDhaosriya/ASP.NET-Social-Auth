#nullable enable
using System.Security.Claims;

namespace GithubAuthApp.Models
{
    public static class ClaimsExtensions
    {
        public static string? FirstClaim(this IEnumerable<Claim>? claims, string type)
        {
            return claims?
                .Where(c => c.Type == type)
                .Select(c => c.Value)
                .FirstOrDefault();
        }

        public static string? AccessToken(this ClaimsPrincipal principal) => 
            principal.Claims.FirstClaim("access_token");
    }
}