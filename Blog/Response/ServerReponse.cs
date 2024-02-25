namespace Blog.Response
{
  public class ServerReponse
  {
    public required string Message { get; set; }
    public int Code { get; set; } = 200;
    public object? Data { get; set; } = null!;
  }
}
