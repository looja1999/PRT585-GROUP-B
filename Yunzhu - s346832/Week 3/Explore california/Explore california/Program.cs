using System.Runtime.CompilerServices;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
    }
    public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory logg)
    {
        LoggerFactory.AddConsole();
        if (Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseFileServer();

    }
}
