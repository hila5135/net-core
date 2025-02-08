using Pool.Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Core.Dtos
{
    public class GuidePutDTO
    {
        public int Id { get; set; }//קוד מדריך
        public string Name { get; set; }//שם מדריך
        public string Tz { get; set; }//תעודת זהות מדריך
        public int Age { get; set; }//גיל מדריך
        public Gender GenderGuide { get; set; }//זכר או נקבה
        public bool Status { get; set; } = true;//סטטוס מדריך
    }
}
