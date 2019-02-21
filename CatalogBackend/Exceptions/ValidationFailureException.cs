using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CatalogBackend.Exceptions
{
    public class ValidationFailureException : BusinessServiceModelStateException
    {
        public ValidationFailureException(ModelStateDictionary modelState) : base("Validation failed", modelState) { }
        public ValidationFailureException(string message, ModelStateDictionary modelState) : base(message, modelState) { }
    }
}
