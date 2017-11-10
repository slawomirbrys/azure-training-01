using Microsoft.Azure.WebJobs;
using NewsCommon.Models;
using NewsCommon.Other;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace NewsWebJob
{
    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        public async static Task ProcessQueueMessageAsync([QueueTrigger("newsappqueue")] string message, TextWriter log)
        {
            News news = JsonConvert.DeserializeObject<News>(message);

            news.Body = news.Body.Replace("a", "A");

            await DocumentDbRepository<News>.CreateItemAsync(news);

            log.WriteLine(string.Format("News \"{0}\" from {1} has been written to DocumentDB.", news.Title, news.Author));
        }
    }
}
