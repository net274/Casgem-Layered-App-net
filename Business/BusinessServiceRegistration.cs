using Business.Abstracts;
using Business.BusinessRules;
using Business.Concretes;
using Core.CrossCuttingConcerns.Security.Jwt;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services) 
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            
            return services;
        }
    }
}
