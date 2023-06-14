using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using RestSharp;

namespace MouseMingleClient.Models;

public class RodentInterest
{
  public int RodentInterestId { get; set; }
  public int RodentId { get; set; }
  public int InterestId { get; set; }

  public Interest Interest { get; set; }
}