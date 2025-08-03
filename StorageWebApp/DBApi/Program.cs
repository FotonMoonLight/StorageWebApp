namespace DBApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddMvc();
        builder.AddServiceDefaults();
        var app = builder.Build();

        app.MapControllers();
        

        app.Run();
    }
}
