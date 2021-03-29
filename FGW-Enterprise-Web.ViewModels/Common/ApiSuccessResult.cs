using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.Common
{
    public class ApiSuccessResult<T>: ApiResult<T>
    {
        public ApiSuccessResult(T resultObj)
        {
            ISuccessed = true;
            ResultObj = resultObj;

        }
        public ApiSuccessResult()
        {
            ISuccessed = true;
        }
    }
}
