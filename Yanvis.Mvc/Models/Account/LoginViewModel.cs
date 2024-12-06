using System.ComponentModel.DataAnnotations;

namespace Yanvis.Mvc.Models.Account;

public class LoginViewModel
{
    [Required(ErrorMessage = "123")]
    public string Login { get; set; }

    [Required(ErrorMessage = "123")]
    public string Password { get; set; }
}
