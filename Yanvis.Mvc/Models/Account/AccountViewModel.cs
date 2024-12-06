using System.ComponentModel.DataAnnotations;

namespace Yanvis.Mvc.Models.Account;

public class AccountViewModel
{
    public LoginViewModel LoginViewModel { get; set; }

    public RegisterViewModel RegisterViewModel { get; set; }
}


