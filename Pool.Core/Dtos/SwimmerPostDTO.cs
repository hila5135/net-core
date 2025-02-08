using Pool.Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Core.Dtos
{
    public class SwimmerPostDTO
    {
        public string Name { get; set; }//שם שוחה
        public string Tz { get; set; }//תעודת זהות שוחה
        public int Age { get; set; }//גיל שוחה
        public Gender GenderSwimmer { get; set; }//זכר או נקבה
        public bool Status { get; set; } = true;//סטטוס שוחה
    }
}
