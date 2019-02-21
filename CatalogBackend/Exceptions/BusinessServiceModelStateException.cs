using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CatalogBackend.Exceptions
{
    public class BusinessServiceModelStateException : BusinessServiceException
    {
        public ModelStateDictionary ModelState { get; set; }

        public BusinessServiceModelStateException(string message, ModelStateDictionary modelState)
            : base(message)
        {
            ModelState = modelState;
        }
    }
}
