using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace RosanicSocial.Application {
    public static class DependencyInjection {
        public static IServiceCollection AddApplication(this IServiceCollection services) {
            return services;
        }
    }
}
