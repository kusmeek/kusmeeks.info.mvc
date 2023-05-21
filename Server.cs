namespace kusmeeks.info.mvc
{
    public class Server
    {
        public static void Main(String[] args)
        {
            WebApplicationBuilder _0 = WebApplication.CreateBuilder(args); _0.Services.AddControllersWithViews();

            WebApplication _1 = _0.Build(); _1.UseStaticFiles(); _1.UseRouting(); _1.UseAuthorization();

            _1.MapControllerRoute(name: "default" , pattern: "{controller=Info}/");

            _1.Run();
        }
    }
}