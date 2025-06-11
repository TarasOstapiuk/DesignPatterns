namespace DesignPatterns.Api
{
  public class Program
  {
    public static void Main( string[] args )
    {
      var builder = WebApplication.CreateBuilder( args );

      builder.Services.AddCors( options =>
      {
        options.AddPolicy( "AllowAll", builder =>
        {
          builder.AllowAnyOrigin()
                 .AllowAnyMethod()
                 .AllowAnyHeader();
        } );
      } );

      builder.Services.AddControllers();

      var app = builder.Build();
      app.UseCors( "AllowAll" );

      app.UseHttpsRedirection();

      app.UseAuthorization();

      app.MapControllers();

      app.Run();
    }
  }
}
