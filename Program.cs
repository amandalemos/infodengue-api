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
                webBuilder.UseStartup<Startup>(); // Usa o Startup.cs para configurações
            })
            .ConfigureServices(services =>
            {
                // Adicionando o HttpClient ao contêiner de dependências
                services.AddHttpClient(); // Este é o serviço para usar HttpClient em toda a aplicação
            });
}
