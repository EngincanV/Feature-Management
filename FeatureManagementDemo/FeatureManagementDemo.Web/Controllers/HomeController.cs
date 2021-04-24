using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;

namespace FeatureManagementDemo.Web.Controllers
{
    [ApiController]
    [Route("/feature-management")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("preview-version")]
        [FeatureGate(Feature.FeatureA)]
        public string Index()
        {
            return $"{Feature.FeatureA} is enabled.";
        }
    }
}