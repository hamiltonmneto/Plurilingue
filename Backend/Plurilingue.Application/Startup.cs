using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Plurilingue.Application.AppService;
using Plurilingue.Application.Interfaces;
using Plurilingue.Domain.Interfaces;
using Plurilingue.Domain.Interfaces.Interfaces.Repositories;
using Plurilingue.Domain.Interfaces.Interfaces.Services;
using Plurilingue.Domain.Interfaces.Repositories;
using Plurilingue.Infra.Data.Repository;
using Plurilingue.Services.Services;

namespace Plurilingue
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddAutoMapper();
            ConfigureBinds(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();

            app.UseMvc();
        }
        private static void ConfigureBinds(IServiceCollection services)
        {
            services.AddTransient<IUserAppService, UserAppService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IQuestionAppService, QuestionAppService>();
            services.AddTransient<IQuestionService, QuestionService>();
            services.AddTransient<IQuestionRepository, QuestionRepository>();
            services.AddTransient<IAnswerAppService, AnswerAppService>();
            services.AddTransient<IAnswerService, AnswerService>();
            services.AddTransient<IAnswerRepository, AnswerRepository>();
        }

    }
}
