﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlanetWeb.Startup))]
namespace PlanetWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
