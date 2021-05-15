using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ECOAPP.WebApi.Filters
{
    /// <summary>
    /// Model state interceptor
    /// </summary>
    public class ValidateModelFilterAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// Create a bad request error based on model state
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }
}
