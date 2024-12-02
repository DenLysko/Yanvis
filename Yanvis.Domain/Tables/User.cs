using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Yanvis.Domain;

public class User
{
    public User(string login, string password)
    {
        Login = login;
        Password = password;
    }

    [Key] // Указывает, что это первичный ключ
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Генерация значения базы данных (автоинкремент)
    public long Id { get; set; }

    [Required] // Указывает, что поле обязательно для заполнения
    public string Login { get; set; }

    [Required]
    public string Password { get; set; }
}