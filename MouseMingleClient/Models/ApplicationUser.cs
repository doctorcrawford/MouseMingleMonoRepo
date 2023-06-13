using Microsoft.AspNetCore.Identity;
using MouseMingleClient.ViewModels;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using RestSharp;

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
    var response = ApiHelper.LoginUserAsync(jsonUser);
    Console.WriteLine("Hummus");
    Console.WriteLine("Hummus");
    Console.WriteLine("Hummus");
    Console.WriteLine(response);
  }
}
