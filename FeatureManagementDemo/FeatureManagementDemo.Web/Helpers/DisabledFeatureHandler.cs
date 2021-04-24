using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.FeatureManagement.Mvc;

namespace FeatureManagementDemo.Web.Helpers
{
    public class DisabledFeatureHandler : IDisabledFeaturesHandler
    {
        public Task HandleDisabledFeatures(IEnumerable<string> features, ActionExecutingContext context)
        {
            var movedPermanentlyStatusCode = (int) HttpStatusCode.MovedPermanently; //301
            
            context.Result = new StatusCodeResult(movedPermanentlyStatusCode); 
            
            return Task.CompletedTask;
        }
    }
}