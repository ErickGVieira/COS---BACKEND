using ApiApk;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using Owin;
using Swashbuckle.Application;
using Swashbuckle.Examples;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Formatting;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Web.Http;
using System.Xml.XPath;

namespace Sanegeo.ApiApk.Classes
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            var httpConfiguration = new HttpConfiguration();
            httpConfiguration.MapHttpAttributeRoutes();
            httpConfiguration.Routes.MapHttpRoute(name: "SanegeoApp_API", routeTemplate: "api/{controller}/{action}", defaults: new { id = RouteParameter.Optional });

			// Configure JSON Formatter for REST API
			var jsonFormatter = httpConfiguration.Formatters.OfType<JsonMediaTypeFormatter>().First();
			jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();


			// Configure CORS to allow JavaScript clients from any domain to access our REST API
			app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);


			// Configure Swagger via Swashbuckle
			httpConfiguration
			.EnableSwagger(
				c => {
					c.SingleApiVersion("api", "Sanegeo App API");

					// Enable Swagger examples
					c.OperationFilter<ExamplesOperationFilter>();

					// Enable swagger descriptions
					c.OperationFilter<DescriptionOperationFilter>();

					// Enable swagger response headers
					c.OperationFilter<AddResponseHeadersFilter>();
				}
			)
			.EnableSwaggerUi();

			

			app.UseWebApi(httpConfiguration);
        }
    }
}
