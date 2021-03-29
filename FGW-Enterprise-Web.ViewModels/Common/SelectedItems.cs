using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.Common
{
    public class SelectedItems
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }

        public object Select()
        {
            throw new NotImplementedException();
        }
    }
}
