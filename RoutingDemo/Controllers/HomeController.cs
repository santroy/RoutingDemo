using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            var r = RouteTable.Routes.GetVirtualPath(null, new RouteValueDictionary(new { controller = "Kontroler", action = "Akcja", id = "12", parametr = "Bartek" }));

            string s = r.VirtualPath;

            string result = Server.HtmlEncode("<script></script>");
            result += "<br>";

            foreach (string routekey in RouteData.Values.Keys)
            {
                //result += "Key: " + routekey + " Value: " + RouteData.Values[routekey] as string;
                //result += "<br>";

                result += string.Format("Key: {0} Value: {1}", routekey, RouteData.Values[routekey] as string);
                result += "<br>";

            
            }
            return result + "\n" + s;
        }
    }
}