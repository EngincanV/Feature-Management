using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
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
            var isEnabled = _featureManager.IsEnabledAsync("IsPreviewVersion");
            
            PreviewVersionMessage = _featureManager.IsEnabledAsync("IsPreviewVersion").Result
                ? "Uygulamanın preview versiyonuna ilgili linkten ulaşabilirsiniz."
                : string.Empty;
        }
    }
}