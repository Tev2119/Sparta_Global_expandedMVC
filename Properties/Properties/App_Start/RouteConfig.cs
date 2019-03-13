using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Properties
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //custom route
            routes.MapMvcAttributeRoutes();


            /*.MapRoute(
                 "PropertiesViews", 
                 "Viewings/opendates/{year}/{month}", 
                new { controller = "Properties", action = "Listings"},
                //specify the numeric system of the url for both the {year} & {month}....can also do = @/"yyyy|yyyy"
               //new { year = @"/d{4}", month = @"/d{2}" });*/

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
