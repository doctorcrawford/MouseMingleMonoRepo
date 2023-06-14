using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using RestSharp;

namespace MouseMingleClient.Models;

public class Rodent
{
  public int RodentId { get; set; }
  public string Species { get; set; }
  public string Name { get; set; }
  public int Age { get; set; }
  public string Location { get; set; }

  public List<RodentInterest> RodentInterests { get; set; }

  public static List<Rodent> GetAll()
  {
    var apiCallTask = ApiHelper.GetAllRodentsAsync();
    var result = apiCallTask.Result;

    var jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
    var rodentList = JsonConvert.DeserializeObject<List<Rodent>>(jsonResponse.ToString());

    return rodentList;
  }

  public static Rodent GetDetails(int id)
  {
    var apiCallTask = ApiHelper.GetDetailsAsync(id);
    var result = apiCallTask.Result;

    var jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    var rodent = JsonConvert.DeserializeObject<Rodent>(jsonResponse.ToString());

    // Get RodentInterests
    // var apiCallTaskRodentInterests = ApiHelper.GetRodentInterest(id);
    // var resultRodentInterest = apiCallTaskRodentInterests.Result;
    // JArray jsonResponseRodentInterests = JsonConvert.DeserializeObject<JArray>(resultRodentInterest);
    // List<RodentInterest> rodentInterests = JsonConvert.DeserializeObject<List<RodentInterest>>(jsonResponseRodentInterests.ToString());

    // rodent.RodentInterests = rodentInterests;
    return rodent;
  }

  public static void Post(Rodent rodent)
  {
    var jsonRodent = JsonConvert.SerializeObject(rodent);
    ApiHelper.PostRodentAsync(jsonRodent);
  }

  public static void Put(Rodent rodent)
  {
    var jsonRodent = JsonConvert.SerializeObject(rodent);
    ApiHelper.PutRodentAsync(rodent.RodentId, jsonRodent);
  }

  public static void Delete(int id)
  {
    ApiHelper.DeleteAsync(id);
  }
}
