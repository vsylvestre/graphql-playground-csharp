using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.Execution;
using HotChocolate.Subscriptions;
using HotChocolate.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Playground
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddRouting()
                .AddInMemorySubscriptions()
                .AddGraphQL(_ =>
                    SchemaBuilder
                        .New()
                        .AddQueryType<Query>()
                        .AddMutationType<Mutation>()
                        .AddSubscriptionType<Subscription>()
                        .Create()
                );
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app
                .UseRouting()
                .UseWebSockets()
                .UseGraphQL()
                .UsePlayground()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapGet("/", async context =>
                    {
                        await context.Response.WriteAsync("Hello World!");
                    });
                });
        }
    }
}