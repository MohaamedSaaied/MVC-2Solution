namespace MVC_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //builder.Services.AddControllersWithViews();
            //Add To Any Service U Need to the Container
            
            
            builder.Services.AddControllersWithViews();//MVC
            //builder.Services.AddControllers();//API
            //builder.Services.AddRazorPages();//RazorPage
            //builder.Services.AddMvc();//MVC
            var app = builder.Build();

            app.UseStaticFiles();

            ////Configure the  HTTP Pipline

            //app.MapGet("/", () => "Hello World!");
            //app.MapGet("/User", () => "Hello User!");
            //app.MapGet("/signin", signin);


            app.MapControllerRoute(
                name: "Defult",
                pattern: "/{controller}/{action}/{id:int?}"
             );


            app.MapControllerRoute(
            name: "Defult",
            pattern: "/{controller}"
 );

            app.Run();
        }
        static string signin()
        {
            return "Signin";
        }
    }
}
