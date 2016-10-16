using Material.Autenticacao.API.Unity;
using Material.IoC;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Microsoft.Practices.Unity;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Owin;
using System;
using System.Web.Http;

namespace Material.Autenticacao.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder builder)
        {
            var config = new HttpConfiguration();
            var container = new UnityContainer();

            ConfigureDependencyInjection(config, container);

            ConfigureWebApi(config);
            ConfigureOAuth(builder);

            builder.UseCors(CorsOptions.AllowAll);
            builder.UseWebApi(config);

        }

        public static void ConfigureWebApi(HttpConfiguration config)
        {
            var formatters = config.Formatters;
            formatters.Remove(formatters.XmlFormatter);

            var jsonSettings = formatters.JsonFormatter.SerializerSettings;
            jsonSettings.Formatting = Formatting.Indented;
            jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.None;

            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );
        }

        public void ConfigureOAuth(IAppBuilder builder)
        {

            var OAuthServerOptions = new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/api/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(1),
                Provider = new CustomProvider()
            };

            builder.UseOAuthAuthorizationServer(OAuthServerOptions);
            builder.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }

        public static void ConfigureDependencyInjection(HttpConfiguration config, UnityContainer container)
        {
            DependencyRegister.Register(container);
            config.DependencyResolver = new UnityResolverHelper(container);
        }

    }
}