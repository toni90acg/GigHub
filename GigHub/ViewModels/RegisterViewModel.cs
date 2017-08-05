using System.ComponentModel.DataAnnotations;

namespace GigHub.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Correo electr�nico")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El n�mero de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contrase�a")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contrase�a")]
        [Compare("Password", ErrorMessage = "La contrase�a y la contrase�a de confirmaci�n no coinciden.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}