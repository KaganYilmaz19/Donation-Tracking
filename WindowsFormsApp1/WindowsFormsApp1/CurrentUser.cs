using System;

public class CurrentUser
{
    public static CurrentUser Instance { get; } = new CurrentUser();

    public string Username { get; private set; }
    public string Role { get; private set; }
    public string Token { get; private set; }
    public DateTime TokenExpiry { get; private set; }
    public bool IsLoggedIn => !string.IsNullOrEmpty(Username) && TokenExpiry > DateTime.Now;

    public void SetUser(string username, string role, string token, DateTime expiry)
    {
        Username = username;
        Role = role;
        Token = token;
        TokenExpiry = expiry;
    }

    public void Logout()
    {
        Username = null;
        Role = null;
        Token = null;
        TokenExpiry = DateTime.MinValue;
    }
}