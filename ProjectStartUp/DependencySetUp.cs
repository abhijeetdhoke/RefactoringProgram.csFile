namespace cleanProgramFile.ProjectStartUp
{
    public static class DependencySetUp
    {
        public static IServiceCollection RegisterService(this IServiceCollection services)
        {
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            //You can add dependency here
            //services.AddTransient<>
            //services.AddScoped<>
            return services;
        }
    }
}