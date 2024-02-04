﻿using Grand.Web.Common.Extensions;
using Grand.Web.Common.Startup;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using StartupBase = Grand.Infrastructure.StartupBase;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseDefaultServiceProvider((_, options) =>
{
    options.ValidateScopes = false;
    options.ValidateOnBuild = false;
});

//add configuration
builder.Configuration.AddAppSettingsJsonFile(args);

//add services
StartupBase.ConfigureServices(builder.Services, builder.Configuration);

builder.ConfigureApplicationSettings();

//register task
builder.Services.RegisterTasks();

//build app
var app = builder.Build();

//request pipeline
StartupBase.ConfigureRequestPipeline(app, builder.Environment);

//run app
app.Run();
