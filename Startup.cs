public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddHttpClient(); // Configura o HttpClient
        services.AddControllersWithViews(); // Adiciona suporte para MVC
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage(); // Para desenvolvimento, exibe detalhes dos erros
        }
        else
        {
            app.UseExceptionHandler("/Home/Error"); // Página de erro
            app.UseHsts();
        }

        app.UseHttpsRedirection(); // Redireciona para HTTPS
        app.UseStaticFiles(); // Servir arquivos estáticos como imagens, CSS, JS

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"); // Roteamento padrão
        });
    }
}
