using System.Threading.Tasks;
using RestSharp;

namespace MouseMingleClient.Models;

public class ApiHelper
{
  private const string HOSTNAME = "http://localhost:####";
  public static async Task<string> GetSearch(string category, string searchParam)
  {
    int rodentAge;
    bool isValid = int.TryParse(searchParam, out rodentAge);
    if (isValid)
    {
      RestClient client = new RestClient(HOSTNAME);
      RestRequest request = new RestRequest($"api/rodents?{category}={rodentAge}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
    if (searchParam == null)
    {
      RestClient client = new RestClient(HOSTNAME);
      RestRequest request = new RestRequest($"api/rodents", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
    else
    {
      RestClient client = new RestClient(HOSTNAME);
      RestRequest request = new RestRequest($"api/rodents?{category}={searchParam}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
  }

  // GET. Returns a list of all rodent profiles
  public static async Task<string> GetAllRodentsAsync()
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/rodents", Method.Get);
    var response = await client.GetAsync(request);

    return response.Content;
  }

  // GET. Gets details of a specific rodent (the user's rodent profile)
  public static async Task<string> GetDetailsAsync(int id)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/rodents/{id}", Method.Get);
    var response = await client.GetAsync(request);

    return response.Content;
  }

  // POST. Happens in Rodents/Create when you submit the questionnarie
  public static async void PostRodentAsync(string newAnimal)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/rodents/", Method.Post);
    request.AddHeader("Content-Type", "application/json");
    request.AddJsonBody(newAnimal);

    await client.PostAsync(request);
  }

  // PUT. Updates existing rodent
  public static async void PutRodentAsync(int id, string newRodent)
  {
    RestClient client = new RestClient(HOSTNAME);
    RestRequest request = new RestRequest($"api/rodents/{id}", Method.Put);
    request.AddHeader("Content-Type", "application/json");
    request.AddJsonBody(newRodent);
    await client.PutAsync(request);
  }

  // DELETE. Deletes a rodent
  public static async void DeleteAsync(int id)
  {
    RestClient client = new RestClient(HOSTNAME);
    RestRequest request = new RestRequest($"api/animals/{id}", Method.Delete);
    request.AddHeader("Content-Type", "application/json");
    await client.DeleteAsync(request);
  }

  //--------------------------------------------- 
  // ^^^^ Rodent Logic ^^^^
  //--------------------------------------------- 
  // vvvv Interest Logic vvvv
  //---------------------------------------------

  // Get all Interests

  public static async Task<string> GetAllInterestsAsync()
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/interests", Method.Get);
    var response = await client.GetAsync(request);

    return response.Content;
  }

  //--------------------------------------------- 
  // vvvv Interest Logic ^^^^
  //---------------------------------------------
  //---------------------------------------------
  // vvvv Account/User Logic vvvv
  //---------------------------------------------

  // POST. Register new user
  public static async void RegisterUserAsync(string newUser)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/accounts/", Method.Post);
    request.AddHeader("Content-Type", "application/json");
    request.AddJsonBody(newUser);

    await client.PostAsync(request);
  }

  public static async void LoginUserAsync(string user)
  {
    var client = new RestClient(HOSTNAME);
    var request = new RestRequest($"api/accounts/", Method.Post);
    request.AddHeader("Content-Type", "application.json");
    request.AddJsonBody(user);

    await client.PostAsync(request);
  }
}