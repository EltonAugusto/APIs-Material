using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Material.Produtos.API.Filters
{
    internal class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.GetValues("Authorization");
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", token);
                try
                {
                    var response = httpClient.GetStringAsync("http://localhost:49399//api/v1/validatetoken").Result;
                }
                catch (Exception ex)
                {
                    actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
                    base.OnAuthorization(actionContext);

                }

            }
        }
    }
}