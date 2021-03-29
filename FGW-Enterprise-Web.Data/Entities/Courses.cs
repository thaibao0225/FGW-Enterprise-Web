using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class Courses
    {
        public string course_Id { get; set; }
        public string course_Name { get; set; }

        public string course_Descrition { get; set; }
        public List<RegisterEvent> RegisterEvent { get; set; }


    }
}
