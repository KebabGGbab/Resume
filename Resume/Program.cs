namespace Resume
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            WebApplication app = builder.Build();

            app.UseRouting();

            app.MapStaticAssets().ShortCircuit();
            app.MapControllers();

            app.Run();
        }
    }
}
