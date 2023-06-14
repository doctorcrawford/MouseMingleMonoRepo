using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MouseMingleClient.Models;

public class Interest
{
  public int InterestId { get; set; }
  public string Description { get; set; }
  public List<RodentInterest> RodentInterests { get; }

  public static List<Interest> GetAll()
  {
    var apiCallTask = ApiHelper.GetAllInterestsAsync();
    var result = apiCallTask.Result;

    var jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
    List<Interest> interestList = JsonConvert.DeserializeObject<List<Interest>>(jsonResponse.ToString());

    return interestList;
  }

  public static Interest GetDetails(int id)
  {
    var apiCallTask = ApiHelper.Get(id);
    var result = apiCallTask.Result;

    var jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    Interest interest = JsonConvert.DeserializeObject<Interest>(jsonResponse.ToString());

    return interest;
  }

  public static void Post (Interest interest)
  {
    string jsonInterest = JsonConvert.SerializeObject(interest);
    ApiHelper.PostRodentAsync(jsonInterest);
  }

  public static void Put(Interest interest)
  {
    string jsonInterest = JsonConvert.SerializeObject(interest);
    ApiHelper.Put(interest.InterestId, jsonInterest);
  }

  public static void Delete(int id)
  {
    ApiHelper.Delete(id);
  }
}