using System.Threading.Tasks;
using RestSharp;
using MouseMingleClient.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;


namespace MouseMingleClient.Models;

public class ApiHelper : ControllerBase
{
  private const string HOSTNAME = "http://localhost:5000";
  public static async Task<string> GetSearch(string category, string searchParam)
  {
    int rodentAge;
    bool isValid = int.TryParse(searchParam, out rodentAge);
    if (isValid)
    {
      RestClient client = new RestClient(HOSTNAME);
      RestRequest request = new RestRequest($"api/v1/rodents?{category}={rodentAge}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
    if (searchParam == null)
    {
      RestClient client = new RestClient(HOSTNAME);
      RestRequest request = new RestRequest($"api/v1/rodents", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
    else
    {
      RestClient client = new RestClient(HOSTNAME);
      RestRequest request = new RestRequest($"api/v1/rodents?{category}={searchParam}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
  }

  // GET. Returns a list of all rodent profiles
  public static async Task<string> GetAllRodentsAsync(string token)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/v1/rodents", Method.Get);
    // request.
    request.AddHeader("Authorization", $"Bearer {token}");
    // request.AddHeader("jwt", $"Bearer{token}");
    var response = await client.GetAsync(request);

    return response.Content;
  }

  // GET. Gets details of a specific rodent (the user's rodent profile)
  public static async Task<string> GetDetailsAsync(int id)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/v1/rodents/{id}", Method.Get);
    // request.AddHeader("Authorization", $"Bearer {token}");
    var response = await client.GetAsync(request);

    return response.Content;
  }

  // POST. Happens in Rodents/Create when you submit the questionnarie
  public static async void PostRodentAsync(string newAnimal)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/v1/rodents/", Method.Post);
    request.AddHeader("Content-Type", "application/json");
    request.AddJsonBody(newAnimal);

    await client.PostAsync(request);
  }

  // PUT. Updates existing rodent
  public static async void PutRodentAsync(int id, string newRodent)
  {
    RestClient client = new RestClient(HOSTNAME);
    RestRequest request = new RestRequest($"api/v1/rodents/{id}", Method.Put);
    request.AddHeader("Content-Type", "application/json");
    request.AddJsonBody(newRodent);
    await client.PutAsync(request);
  }

  // DELETE. Deletes a rodent
  public static async void DeleteAsync(int id)
  {
    RestClient client = new RestClient(HOSTNAME);
    RestRequest request = new RestRequest($"api/v1/rodents/{id}", Method.Delete);
    request.AddHeader("Content-Type", "application/json");
    await client.DeleteAsync(request);
  }

  //--------------------------------------------- 
  // ^^^^ Rodent Logic ^^^^
  //--------------------------------------------- 


  //--------------------------------------------- 
  // vvvv Interest Logic vvvv
  //---------------------------------------------

  // Get all Interests

  public static async Task<string> GetAllInterestsAsync()
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/v1/interests", Method.Get);
    var response = await client.GetAsync(request);

    return response.Content;
  }

  // Get Interest by InterestId
  public static async Task<string> Get(int id)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/v1/interests/{id}", Method.Get);
    var response = await client.GetAsync(request);

    return response.Content;
  }

  // Post new interest
  public static async void Post (string newInterest)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/v1/interests/", Method.Post);
    request.AddHeader("Content-Type", "application/json");
    request.AddJsonBody(newInterest);

    await client.PostAsync(request);
  }

  // Put Updates existing interest
  public static async void Put(int id, string newInterest)
  {
    RestClient client = new RestClient(HOSTNAME);
    RestRequest request = new RestRequest($"api/v1/interest/{id}", Method.Put);
    request.AddHeader("Content-Type", "application/json");
    request.AddJsonBody(newInterest);
    await client.PutAsync(request);
  }

  // Delete Interest by Id
  public static async void Delete(int id)
  {
    RestClient client = new RestClient(HOSTNAME);
    RestRequest request = new RestRequest($"api/v1/interests/{id}", Method.Delete);
    request.AddHeader("Content-Type", "application/json");
    await client.DeleteAsync(request);
  }

  //--------------------------------------------- 
  // ^^^^ Interest Logic ^^^^
  //---------------------------------------------

    //--------------------------------------------- 
  // vvvv RodentInterest Logic vvvv
  //---------------------------------------------


    // Get RodentInterest at Rodent
  public static async Task<string> GetRodentInterest(int id)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/v1/rodent/{id}/rodentinterests", Method.Get);
    var response = await client.GetAsync(request);

    return response.Content;
  }

  //---------------------------------------------
  // vvvv Account/User Logic vvvv
  //---------------------------------------------

  // POST. Register new user
  public static async void RegisterUserAsync(string newUser)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/v1/accounts/", Method.Post);
    request.AddHeader("Content-Type", "application/json");
    request.AddJsonBody(newUser);

    await client.PostAsync(request);
  }

  public static async Task<string> LoginUserAsync(string user)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/v1/authenticate/login", Method.Post);
    request.AddHeader("Content-Type", "application/json");
    request.AddJsonBody(user);

    var response = await client.ExecuteAsync(request);
    Console.WriteLine("Dragon");
    Console.WriteLine("Dragon");
    Console.WriteLine("Dragon");
    return response.Content;
  }
}