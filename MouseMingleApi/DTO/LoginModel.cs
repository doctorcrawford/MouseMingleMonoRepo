using System.ComponentModel.DataAnnotations;

namespace MouseMingleApi.DTO;

public class LoginModel
{
  #nullable enable
  [Required(ErrorMessage ="User Name is required")]
  public string? Username { get; set; }

  [Required(ErrorMessage ="Password is required")]
  public string? Password { get; set; }
}