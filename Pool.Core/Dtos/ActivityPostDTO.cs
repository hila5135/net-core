using Pool.Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Core.Dtos
{
    public class ActivityPostDTO
    {
        public string Name { get; set; }//שם הפעילות
        public TimeSpan BeginHour { get; set; }//שעת התחלה
        public TimeSpan EndHour { get; set; }//שעת סיום
        public Day ActivityDay { get; set; }//יום הפעילות
        public bool Status { get; set; } = true;//סטטוס פעילות
        public int GuideId { get; set; }

    }
}
