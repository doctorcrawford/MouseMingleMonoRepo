namespace MouseMingleClient.ViewModels;

public record TokenModel
{
  public string Token { get; set; }
  public string Expiration { get; set; }
}