using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace MyPatchSG.API.Attributes
{
    public class RequiredParametersFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var requiredParameters = GetRequiredParameters(actionContext);

            ValidateParameters(actionContext, requiredParameters);

            base.OnActionExecuting(actionContext);
        }

        private void ValidateParameters(HttpActionContext actionContext, List<string> requiredParameters)
        {
            if (requiredParameters == null || requiredParameters.Count == 0)
                return;

            var nullParameter = actionContext.ActionArguments.FirstOrDefault(a => requiredParameters.Contains(a.Key) && a.Value == null);

            if (!string.IsNullOrWhiteSpace(nullParameter.Key))
            {
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(String.Format("The {0} is required", nullParameter.Key))
                });
            }
        }

        private List<string> GetRequiredParameters(HttpActionContext actionContext)
        {
            return actionContext.ActionDescriptor
                  .GetParameters()
                  .Where(p => p.GetCustomAttributes<RequiredAttribute>().FirstOrDefault() != null)
                  .Select(p => p.ParameterName)
                  .ToList();
        }

    }
}