namespace Yanvis.Domain;

public class User
{
    public User(string login, string password)
    {
        Login = login;
        Password = password;
    }
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
