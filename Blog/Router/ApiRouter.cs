namespace Blog.Router
{
  public static class ApiRouter
  {
    public static RouteGroupBuilder ApiRouterPlugin(this RouteGroupBuilder group)
    {
      group.MapGet("/", Status);
      return group;
    }

    private static Ok<ServerReponse> Status()
    {
      return TypedResults.Ok<ServerReponse>(new (){
        Message = "Ok",
        Data = new() { }
      });
    }
  }
}

