using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.Common
{
    public class PagedResult<T>: PageResultBase
    {
        public List<T> Items { set; get; }

    }
}
