//using Microsoft.AspNetCore.Mvc;
//using Umbraco.Cms.Core.Cache;
//using Umbraco.Cms.Core.Logging;
//using Umbraco.Cms.Core.Routing;
//using Umbraco.Cms.Core.Services;
//using Umbraco.Cms.Core.Web;
//using Umbraco.Cms.Infrastructure.Persistence;
//using Umbraco.Cms.Web.Common.Filters;
//using Umbraco.Cms.Web.Website.Controllers;

using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace Chaythu.Controllers
{
    public class HomeDocumentController : SurfaceController
    {
        public HomeDocumentController(
           IUmbracoContextAccessor umbracoContextAccessor,
           IUmbracoDatabaseFactory databaseFactory,
           ServiceContext services,
           AppCaches appCaches,
           IProfilingLogger profilingLogger,
           IPublishedUrlProvider publishedUrlProvider)
           : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            //var see = UmbracoContext;
            //var see2 = UmbracoContextAccessor;
            //var see3 = Services;
            var Model = CurrentPage;

            return View("Home", Model);
        }
    }
}
