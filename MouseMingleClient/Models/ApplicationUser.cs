using Microsoft.AspNetCore.Identity;
using MouseMingleClient.ViewModels;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace MouseMingleClient.Models;

public class ApplicationUser : IdentityUser
{
  public async static Task RegisterAsync(RegisterViewModel newUser)
  {
    var jsonNewUser = JsonConvert.SerializeObject(newUser);
    await ApiHelper.RegisterUserAsync(jsonNewUser);
  }

  public static Task<TokenModel> LoginAsync(LoginViewModel user)
  {
    return ApiHelper.LoginUserAsync(user);
  }
}
