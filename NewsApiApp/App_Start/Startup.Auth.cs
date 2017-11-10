using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.ActiveDirectory;
using Owin;
using System.IdentityModel.Tokens;

namespace NewsApiApp
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            //// STAGE5 - Odkomentowac
            //app.UseWindowsAzureActiveDirectoryBearerAuthentication(
            //    new WindowsAzureActiveDirectoryBearerAuthenticationOptions
            //    {
            //        Tenant = ConfigurationManager.AppSettings["ida:Tenant"],
            //        TokenValidationParameters = new TokenValidationParameters
            //        {
            //            ValidAudience = ConfigurationManager.AppSettings["ida:Audience"]
            //        }
            //    });
        }

    }
}

