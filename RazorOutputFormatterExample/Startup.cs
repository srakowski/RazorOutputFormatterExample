// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RazorOutputFormatterExample.Models;
using Microsoft.Net.Http.Headers;

namespace RazorOutputFormatterExample
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
            services.AddMvc(options => {
                options.OutputFormatters.Add(new RazorOutputFormatter(type =>
                    typeof(Gargoyle).IsAssignableFrom(type) ? "Gargoyle" :
                    typeof(IEnumerable<Gargoyle>).IsAssignableFrom(type) ? "Gargoyles" :
                    string.Empty));

                options.FormatterMappings.SetMediaTypeMappingForFormat(
                    "html", new MediaTypeHeaderValue("text/html"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
