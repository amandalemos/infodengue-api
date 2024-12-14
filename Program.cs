using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>(); // Usa o Startup.cs para configura��es
            })
            .ConfigureServices(services =>
            {
                // Adicionando o HttpClient ao cont�iner de depend�ncias
                services.AddHttpClient(); // Este � o servi�o para usar HttpClient em toda a aplica��o
            });
}
