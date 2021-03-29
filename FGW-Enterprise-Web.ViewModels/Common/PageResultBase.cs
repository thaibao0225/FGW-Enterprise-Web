using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.Common
{
    public class PageResultBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalRecore { get; set; }
        public int CountPage
        {
            get
            {
                var countPage = (double)TotalRecore / PageSize;
                return (int)Math.Ceiling(countPage);
            }
        }


    }
}
