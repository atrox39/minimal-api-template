namespace Blog.Config
{
  public static class AppConfig
  {
    public static WebApplication AppConfigPlugin(this WebApplication app)
    {
      if (app.Environment.IsDevelopment())
      {
        app.UseSwagger();
        app.UseSwaggerUI();
      }
      app.UseHttpsRedirection();
      return app;
    }
  }
}
