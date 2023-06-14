using Microsoft.AspNetCore.Identity;
using MouseMingleClient.ViewModels;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace MouseMingleClient.Models;

public class ApplicationUser : IdentityUser
{
  public static void Register(RegisterViewModel newUser)
  {
    var jsonNewUser = JsonConvert.SerializeObject(newUser);
    ApiHelper.RegisterUserAsync(jsonNewUser);
  }

  public static TokenModel Login(LoginViewModel user)
  {
    var jsonUser = JsonConvert.SerializeObject(user);
    var apiCallTask =  ApiHelper.LoginUserAsync(jsonUser);
    var result = apiCallTask.Result;

    var jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    var tokenModel = JsonConvert.DeserializeObject<TokenModel>(jsonResponse.ToString());

    return tokenModel;
  }
}
