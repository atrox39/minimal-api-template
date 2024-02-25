namespace Blog.Config
{
  public static class ServiceConfig
  {
    public static WebApplicationBuilder ServiceConfigPlugin(this WebApplicationBuilder builder)
    {
      builder.Services.AddEndpointsApiExplorer();
      builder.Services.AddSwaggerGen();
      return builder;
    }
  }
}

