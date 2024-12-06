using System.ComponentModel.DataAnnotations;

namespace Yanvis.Mvc.Models.Account;

public class RegisterViewModel
{
    [Required(ErrorMessage = "123")]
    public string Login { get; set; }

    [Required(ErrorMessage = "123")]
    public string Password { get; set; }

    [Required(ErrorMessage = "123")]
    public string RepeatPassword { get; set; }
}
