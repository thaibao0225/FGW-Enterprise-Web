using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class RegisterEvent
    {
        public string resEvent_CourseId { get; set; }
        public Course Course { get; set; }

        public Guid resEvent_UserId { get; set; }
        public User User { get; set; }


        public string resEvent_DeadlineCate { get; set; }
        public DeadlineCate DealineCate { get; set; }


        public string resEvent_EventId { get; set; }
        public Event Event { get; set; }



    }
}
