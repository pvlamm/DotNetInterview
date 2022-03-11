namespace DotNetInterview.Core;

public class UserValidation
{
    private Dictionary<string, string> _users = new Dictionary<string, string>();

    public UserValidation()
    {
        _users.Add("username", "password");
        _users.Add("abbyalpha", "password123");
    }

    public bool Authenticate(string username, string password)
    {
        if (_users.ContainsKey(username) && _users[username] == password)
        {
            return true;
        }

        return false;
    }
}
