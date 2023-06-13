using System.Collections.Generic;

namespace MouseMingleApi.Models;

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
}