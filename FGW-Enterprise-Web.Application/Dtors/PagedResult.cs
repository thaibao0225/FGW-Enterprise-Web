using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Application.Dtors
{
    public class PagedResult<T>
    {
        public List<T> Items { set; get; }
        public int TotalRecore { set; get; }

    }
}
