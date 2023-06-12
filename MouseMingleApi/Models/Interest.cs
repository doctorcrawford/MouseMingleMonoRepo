using System.Collections.Generic;

namespace MouseMingleApi.Models;

public class Interest
{
  public int InterestId { get; set; }
  public string Description { get; set; }
  public List<RodentInterest> RodentInterests { get; set; }
}