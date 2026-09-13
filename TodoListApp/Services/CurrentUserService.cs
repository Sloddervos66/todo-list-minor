using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace TodoListApp.Services;

public sealed class CurrentUserService(AuthenticationStateProvider authenticationStateProvider) : ICurrentUserService
{
    public async Task<Guid> GetUserIdAsync()
    {
        var authState = await authenticationStateProvider.GetAuthenticationStateAsync();
        var userId = authState.User.FindFirstValue(ClaimTypes.NameIdentifier);
        
        return Guid.TryParse(userId, out var guid) 
            ? guid 
            : throw new InvalidOperationException("No authenticated user ID was found.");
    }
}