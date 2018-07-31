﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ntt_time
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // services.AddSwagger();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

        //     app.UseSwaggerUi3WithApiExplorer(s =>
        // {
        //     s.SwaggerRoute = "/swagger/v1/swagger.json";
        //     s.SwaggerUiRoute = "/swagger";

        //     s.GeneratorSettings.DocumentProcessors.Add(new SecurityDefinitionAppender("TEST_HEADER", new SwaggerSecurityScheme
        //     {
        //         Type = SwaggerSecuritySchemeType.ApiKey,
        //         Name = "TEST_HEADER",
        //         In = SwaggerSecurityApiKeyLocation.Header,
        //         Description = "TEST_HEADER"
        //     }));
        // });

            app.UseMvc();

            app.UseStaticFiles();
        }
    }
}
