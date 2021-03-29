using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.Common
{
    public class ApiResult<T>
    {
        public bool ISuccessed { get; set; }
        public string Message { get; set; }
        public T ResultObj { get; set; }


    }
}
