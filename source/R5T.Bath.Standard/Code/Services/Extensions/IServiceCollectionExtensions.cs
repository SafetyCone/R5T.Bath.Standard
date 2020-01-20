using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bath.File.Standard;


namespace R5T.Bath.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddHumanOutput(this IServiceCollection services)
        {
            services.AddFileHumanOutput();

            return services;
        }
    }
}
