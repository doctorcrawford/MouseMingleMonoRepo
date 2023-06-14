using Microsoft.AspNetCore.Identity;
using MouseMingleClient.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using RestSharp;
using System.Net;

namespace MouseMingleClient.Models;

public class ApplicationUser : IdentityUser
{
  public static void Register(RegisterViewModel newUser)
  {
    var jsonNewUser = JsonConvert.SerializeObject(newUser);
    ApiHelper.RegisterUserAsync(jsonNewUser);
  }

  public static void Login(LoginViewModel user)
  {
    var jsonUser = JsonConvert.SerializeObject(user);
    var apiCallTask = ApiHelper.LoginUserAsync(jsonUser);
    var result = apiCallTask.Result;

    var jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    var tokenModel = JsonConvert.DeserializeObject<TokenModel>(jsonResponse.ToString());
    var cookie = new Cookie("token", tokenModel.Token);


    Console.WriteLine("Hummus");
    Console.WriteLine("Hummus");
    Console.WriteLine("Hummus");
    Console.WriteLine(cookie);
  }
}
