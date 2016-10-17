using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Http.Controllers;
using WebApi.OutputCache.V2;

namespace Material.Produtos.API.Filters
{
    internal class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.GetValues("Authorization");
            var url = UriOauth();
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", token);
                try
                {
                    var response = httpClient.GetStringAsync(url).Result;
                }
                catch (Exception ex)
                {
                    actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                    base.OnAuthorization(actionContext);

                }

            }
        }

        [CacheOutput(ClientTimeSpan = 200)]
        public static string UriOauth()
        {
            return WebConfigurationManager.AppSettings["urloauth"].ToString();
        }
    }
}