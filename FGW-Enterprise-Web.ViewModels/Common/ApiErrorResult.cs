using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.Common
{
    public class ApiErrorResult<T>:ApiResult<T>
    {
        public string[] ValidationErrors { get; set; }
        public ApiErrorResult(string message)
        {
            ISuccessed = false;
            Message = message;

        }
        public ApiErrorResult(string[] validationErrors)
        {
            ISuccessed = false;
            ValidationErrors = validationErrors;
        }
    }
}
