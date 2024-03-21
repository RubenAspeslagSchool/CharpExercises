using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Shaired.ExtentionMethods
{
    public static class WebApplicationExtensions
    {
        public static void Deconstruct(this WebApplicationBuilder builder,
           out WebApplicationBuilder applicationBuilder,
           out IServiceCollection services,
           out ConfigurationManager configuration)
        {
            applicationBuilder = builder;
            services = builder.Services;
            configuration = builder.Configuration;
        }

    }
}
