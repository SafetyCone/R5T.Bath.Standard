using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Bath.File.Standard;


namespace R5T.Bath.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a file-based <see cref="IHumanOutput"/> service.
        /// </summary>
        public static IServiceCollection AddHumanOutput(this IServiceCollection services)
        {
            services.AddFileHumanOutput();

            return services;
        }
    }
}
