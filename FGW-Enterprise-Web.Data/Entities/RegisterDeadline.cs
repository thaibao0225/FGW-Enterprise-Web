using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class RegisterDeadline
    {
        public string rd_DeadlineId { get; set; }
        public Deadline Dealine { get; set; }
        public string rd_DeadineCate { get; set; }
        public DeadlineCate DealineCate { get; set; }

    }
}
