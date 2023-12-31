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
  public string ProfilePic { get; set; }
  public int UpVote { get; set; }
  public List<RodentInterest> RodentInterests { get; set; }

  public async static Task<List<Rodent>> GetAllAsync(string token)
  {
    var rodentList = await ApiHelper.GetAllRodentsAsync(token);

    return rodentList;
  }

  public static Rodent GetDetails(int id)
  {
    var apiCallTask = ApiHelper.GetDetailsAsync(id);
    var result = apiCallTask.Result;

    var jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    var rodent = JsonConvert.DeserializeObject<Rodent>(jsonResponse.ToString());

    return rodent;
  }

  // public static Rodent FindMyIdWithMyName(Rodent rodent)
  // {
  //   var myRodentsName = rodent.Name;
  //   var apiCallTask = ApiHelper.GetIdWithName(myRodentsName);
  //   var result = apiCallTask.Result;

  //   var jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
  //   var myRodent = JsonConvert.DeserializeObject<Rodent>(jsonResponse.ToString());

  //   return myRodent;
  // }

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

  public static Rodent AddInterestToRodents(int rodentId, int interestIdYo)
  {
    var apiCallTask =  ApiHelper.AddInterestToRodentsAsync(rodentId, interestIdYo);
    var result = apiCallTask.Result;

    var jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    var rodent = JsonConvert.DeserializeObject<Rodent>(jsonResponse.ToString());
    return rodent;
  }
}