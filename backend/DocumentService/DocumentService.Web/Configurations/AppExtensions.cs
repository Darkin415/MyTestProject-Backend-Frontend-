namespace DocumentService.Web.Configurations;

public static class AppExtensions
{
    public static IApplicationBuilder Configure(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(options => 
            { 
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Document Service V1"); 
            });
        }
        
        return app;
    }
}