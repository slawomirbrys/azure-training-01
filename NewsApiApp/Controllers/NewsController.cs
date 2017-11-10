using NewsCommon.Models;
using NewsCommon.Other;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;

namespace NewsApiApp.Controllers
{
    [AllowAnonymous]
    public class NewsController : ApiController
    {
        const string EXAMPLEBODY = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur accumsan egestas interdum. Curabitur sollicitudin ipsum in vulputate molestie. Donec vitae finibus felis. Nulla mattis blandit erat, a iaculis sapien molestie ultricies. Ut at massa enim. Sed nec molestie enim. Vestibulum accumsan porta tempor. Fusce porta sapien sagittis, consequat libero et, efficitur purus. Nullam mauris dolor, pharetra gravida enim sed, dignissim faucibus urna. Maecenas eget nisl enim. Morbi ultrices augue eget odio auctor, et commodo mauris ultrices. Donec blandit, nisi in congue consequat, orci dolor accumsan lectus, a rutrum purus lorem eget mi.";

        // STAGE3 - Zakomentowac metode
        // GET: anonymous/allnews
        [Route("anonymous/allnews")]
        public  IEnumerable<News> Get()
        {
            return new List<News> {
                new News { Id="1", Title="First News", Body=EXAMPLEBODY, Created=DateTime.Now, Author="Jan Kowalski" },
                new News { Id="2", Title="Second News", Body=EXAMPLEBODY, Created=DateTime.Now, Author="Anna Nowak" }
            };
        }


        //// STAGE3 - Odkomentowac metode
        //// GET: anonymous/allnews
        //[Route("anonymous/allnews")]
        //public async Task<IEnumerable<News>> Get()
        //{
        //    return await DocumentDbRepository<News>.GetItemsAsync(n => n.Id!="");
        //}


        //// STAGE3 - Odkomentowac metode 
        //// POST: api/News 
        ////// STAGE5 - Odkomentowac [Authorize]
        //// [Authorize] 
        //public async Task Post([FromBody]News value)
        //{
        //    value.Created = DateTime.Now;
        //    value.Author = "Anonymous";

        //    //// STAGE5 - Odkomentowac 
        //    //if (ClaimsPrincipal.Current.Identity.IsAuthenticated) 
        //    //{ 
        //    //    string AuthorIdentifier = ClaimsPrincipal.Current.FindFirst(ClaimTypes.NameIdentifier).Value; 
        //    //    string AuthorName = ClaimsPrincipal.Current.FindFirst("name").Value; 
        //    //    value.Author = AuthorName; 

        //    // STAGE4 - Zakomentowac 
        //    await DocumentDbRepository<News>.CreateItemAsync(value);

        //    //// STAGE4 - Odkomentowac 
        //    //QueueHelper<News> queueHelper = new QueueHelper<News>(); 
        //    //queueHelper.Initialize( 
        //    //    ConfigurationManager.AppSettings["asConnectionString"], 
        //    //    ConfigurationManager.AppSettings["asQueueName"] 
        //    //    ); 
        //    //await queueHelper.SendMessageAsync(value); 

        //    //// STAGE5 - Odkomentowac 
        //    //} 
        //    //else 
        //    //    throw new HttpResponseException(HttpStatusCode.Unauthorized); 

        //}



    }
}
