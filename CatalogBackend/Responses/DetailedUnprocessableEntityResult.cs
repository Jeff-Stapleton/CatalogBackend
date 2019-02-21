using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CatalogBackend.Responses
{
    public class DetailedUnprocessableEntityResult : ObjectResult
    {
        public DetailedUnprocessableEntityResult(ModelStateDictionary modelState) : base(new SerializableError(modelState))
        {
            if (modelState == null)
            {
                throw new ArgumentNullException(nameof(modelState));
            }
            StatusCode = StatusCodes.Status422UnprocessableEntity;
        }
    }
}
