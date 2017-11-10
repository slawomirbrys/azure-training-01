using Microsoft.Azure.WebJobs;
using NewsCommon.Models;
using NewsCommon.Other;
using System.Configuration;

namespace NewsWebJob
{
    // To learn more about Microsoft Azure WebJobs SDK, please see https://go.microsoft.com/fwlink/?LinkID=320976
    class Program
    {
        // Please set the following connection strings in app.config for this WebJob to run:
        // AzureWebJobsDashboard and AzureWebJobsStorage
        static void Main()
        {
            var config = new JobHostConfiguration();

            if (config.IsDevelopment)
            {
                config.UseDevelopmentSettings();
            }

            DocumentDbRepository<News>.Initialize(
                ConfigurationManager.AppSettings["ddbEndpoint"],
                ConfigurationManager.AppSettings["ddbAuthKey"],
                ConfigurationManager.AppSettings["ddbDatabase"],
                ConfigurationManager.AppSettings["ddbCollection"]
                );

            var host = new JobHost();
            // The following code ensures that the WebJob will be running continuously
            host.RunAndBlock();
        }
    }
}
