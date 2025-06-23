using Microsoft.AspNetCore.Components.Authorization;

namespace App;

public class AuthHelper
{
    public static async Task<string?> GetUserId(Task<AuthenticationState> getAuthenticationStateAsync)
    {
        var authState = await getAuthenticationStateAsync;
        var user = authState.User;
        var objectId = user.Claims.FirstOrDefault(c => c.Type == "http://schemas.microsoft.com/identity/claims/objectidentifier")?.Value;

        return objectId;
    }
}