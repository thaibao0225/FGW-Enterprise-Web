using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class Event
    {
        public string event_Id { get; set; }
        public string event_Name { get; set; }
        public string event_Description { get; set; }
        public string event_CreateBy { get; set; }
        public DateTime event_CreateDate { get; set; }
        public string event_ModifiedBy { get; set; }
        public string event_Status { get; set; }
        public List<RegisterEvent> RegisterEvent { get; set; }
    }
}
