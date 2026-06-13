using System;
using HR_LeaveManagement.Application.Profiles;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace HR_LeaveManagement.Application
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            // Register application services here, e.g.:
            // services.AddTransient<IMyService, MyService>();
            services.AddAutoMapper(assemblies: new[] { Assembly.GetExecutingAssembly() });
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
