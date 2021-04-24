using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.FeatureManagement;

namespace FeatureManagementDemo.Web.Pages
{
    public class IndexModel : PageModel
    {
        public string PreviewVersionMessage { get; set; }
        
        private readonly IFeatureManager _featureManager;

        public IndexModel(IFeatureManager featureManager)
        {
            _featureManager = featureManager;
        }

        public void OnGet()
        {
            PreviewVersionMessage = (_featureManager.IsEnabledAsync(Feature.IsPreviewVersion).Result)
                ? "You can reach the preview version by using the below link."
                : string.Empty;
        }
    }
}