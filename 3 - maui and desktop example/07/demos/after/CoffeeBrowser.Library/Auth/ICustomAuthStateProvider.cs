using Microsoft.AspNetCore.Components.Authorization;

namespace CoffeeBrowser.Library.Auth
{
    public interface ICustomAuthStateProvider
    {
        Task<AuthenticationState> GetAuthenticationStateAsync();
        Task LogInAsync();
        void Logout();
    }
}