using CatalogBackend.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CatalogBackend.Exceptions
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is ValidationFailureException validationFailureException)
            {
                if (validationFailureException.ModelState.ContainsKey(string.Empty))
                {
                    context.Result = new BadRequestObjectResult(validationFailureException.ModelState);
                }
                else
                {
                    context.Result = new DetailedUnprocessableEntityResult(validationFailureException.ModelState);
                }
            }
        }
    }
}
