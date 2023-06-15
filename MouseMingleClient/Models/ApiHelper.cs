using System.Threading.Tasks;
using RestSharp;
using MouseMingleClient.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http.Headers;

namespace MouseMingleClient.Models;

public class ApiHelper : ControllerBase
{
  private const string HOSTNAME = "https://localhost:5001";
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
  public static async Task<List<Rodent>> GetAllRodentsAsync(string token)
  {
    using var httpClient = new HttpClient();
    httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
    var path = HOSTNAME + "/api/v1/rodents";
    var response = await httpClient.GetFromJsonAsync<List<Rodent>>(path);

    return response;
  }

  // GET. Gets details of a specific rodent (the user's rodent profile)
  public static async Task<string> GetDetailsAsync(int id)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/v1/rodents/{id}", Method.Get);
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

  public static async Task<string> GetIdWithName(string myRodentsName)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/v1/rodents/{myRodentsName}", Method.Get);
    var response = await client.GetAsync(request);

    return response.Content;
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

  public static async Task<string> GetAllInterestsByRat(int id)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/v1/interests/rodents/{id}");
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
    RestRequest request = new RestRequest($"api/v1/interests/{id}", Method.Put);
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

    // Get All RodentInterests
<<<<<<< HEAD
  public static async Task<string> GetAllRodentInterests()
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/v1/interests", Method.Get);
    var response = await client.GetAsync(request);

    return response.Content;
  }
=======
  // public static async Task<string> GetAllRodentInterests()
  // {
  //   var client = new RestClient(HOSTNAME);
  //   var request = new RestRequest($"api/v1/interests", Method.Get);
  //   var response = await client.GetAsync(request);  
  // }
>>>>>>> 3da6b6da2ba49df8efbecdb0ae696889107fed26
    // Get RodentInterest at Rodent
  public static async Task<string> GetRodentInterest(int id)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/v1/rodents/{id}/rodentinterests", Method.Get);
    var response = await client.GetAsync(request);

    return response.Content;
  }

  public static async Task<string> AddInterestToRodentsAsync(int rodentId, int interestIdYo)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/v1/rodents/{rodentId}/interests/{interestIdYo}", Method.Post);
    // request.AddHeader("Content-Type", "application/json");
    var response = await client.PostAsync(request);

    return response.Content;
  }

  //---------------------------------------------
  // vvvv Account/User Logic vvvv
  //---------------------------------------------

  // POST. Register new user
  public static async Task RegisterUserAsync(string newUser)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/v1/Authenticate/register", Method.Post);
    request.AddHeader("Content-Type", "application/json");
    request.AddJsonBody(newUser);

    await client.PostAsync(request);
  }

  public static async Task<TokenModel> LoginUserAsync(LoginViewModel user)
  {
    using var httpClient = new HttpClient();
    var path = HOSTNAME + "/api/v1/authenticate/login";
    var resp = await httpClient.PostAsJsonAsync<LoginViewModel>(path, user);

    var options = new JsonSerializerOptions
    {
      PropertyNameCaseInsensitive = true,
    };
    var tokenModel = await resp.Content.ReadFromJsonAsync<TokenModel>(options, CancellationToken.None);

    // var content = await resp.Content.ReadAsStringAsync();
    // var content = await resp.Content.ReadAsStreamAsync ();
    // var tokenModel = JsonSerializer.Deserialize<object>(content);


    return tokenModel;

    // var parsedJson = await JsonSerializer.DeserializeAsync<DTOGoodAccount>(resp.Content.ReadAsStream());

    // var client = new RestClient(HOSTNAME);
    // var request = new RestRequest($"api/v1/authenticate/login", Method.Post);
    // request.AddHeader("Content-Type", "application/json");
    // request.AddJsonBody(user);

    // var response = await client.ExecuteAsync(request);
    // Console.WriteLine("Dragon");
    // Console.WriteLine("Dragon");
    // Console.WriteLine("Dragon");
    // return response.Content;
  }
}