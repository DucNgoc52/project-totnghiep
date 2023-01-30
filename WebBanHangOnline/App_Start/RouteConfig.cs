using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebBanHangOnline
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Products",
                url: "mon-an",
                defaults: new { controller = "Products", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }
            );
            routes.MapRoute(
                name: "CategoryProduct",
                url: "danh-muc-san-pham/{alias}-{id}",
                defaults: new { controller = "Products", action = "ProductCategory", id = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }
            );
            routes.MapRoute(
                name: "Contacts",
                url: "lien-he",
                defaults: new { controller = "Contacts", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }
            );
            routes.MapRoute(
                name: "New",
                url: "tin-tuc",
                defaults: new { controller = "New", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }
            );
            routes.MapRoute(
                name: "CheckOut",
                url: "thanh-toan",
                defaults: new { controller = "ShoppingCart", action = "CheckOut", alias = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }
            );
            routes.MapRoute(
                name: "Bookings",
                url: "dat-ban",
                defaults: new { controller = "Booking", action = "Index", alias = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }
            );
            routes.MapRoute(
                name: "Details",
                url: "chi-tiet/{alias}-p{id}",
                defaults: new { controller = "Products", action = "Detail", id = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }
            );
            routes.MapRoute(
                name: "ShoppingCart",
                url: "shoppingcart",
                defaults: new { controller = "ShoppingCart", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "WebBanHangOnline.Controllers" }
            );
        }
    }
}
