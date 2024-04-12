using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace RosanicSocial.Infrastructure {
    public static class DependecyInjection {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services) {
            return services;
        }
    }
}
