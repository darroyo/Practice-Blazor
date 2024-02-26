using System;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using CoffeeBrowser.Library.Auth;
using Microsoft.AspNetCore.Components.Authorization;

namespace CoffeeBrowser.WinForms.Auth;

public class CustomAuthStateProvider : AuthenticationStateProvider, ICustomAuthStateProvider
{
    private ClaimsPrincipal currentUser = GetWindowsPrincipal();

    public override Task<AuthenticationState> GetAuthenticationStateAsync() =>
        Task.FromResult(new AuthenticationState(currentUser));

    public Task LogInAsync()
    {
        var loginTask = LogInAsyncCore();
        NotifyAuthenticationStateChanged(loginTask);

        return loginTask;

        async Task<AuthenticationState> LogInAsyncCore()
        {
            var user = await LoginWithExternalProviderAsync();
            currentUser = user;

            return new AuthenticationState(currentUser);
        }
    }

    private Task<ClaimsPrincipal> LoginWithExternalProviderAsync()
    {
        ClaimsPrincipal authenticatedUser = GetWindowsPrincipal();

        return Task.FromResult(authenticatedUser);
    }

    private static ClaimsPrincipal GetWindowsPrincipal()
    {
        var identity = WindowsIdentity.GetCurrent();

        return new WindowsPrincipal(identity);
    }

    public void Logout()
    {
        currentUser = new ClaimsPrincipal(new ClaimsIdentity());
        NotifyAuthenticationStateChanged(
            Task.FromResult(new AuthenticationState(currentUser)));
    }
}