using System.ComponentModel.DataAnnotations;

namespace MouseMingleClient.ViewModels
{
  public class DeleteViewModel
  {
    [Required]
    [EmailAddress]
    [Display(Name = "Email Address")]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
  }
}