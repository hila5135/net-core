using System.Reflection;

namespace Pool.Core.models
{
    public class Guide
    {
        public int Id { get; set; }//קוד מדריך
        public string Name { get; set; }//שם מדריך
        public string Tz{ get; set; }//תעודת זהות מדריך
        public int Age { get; set; }//גיל מדריך
        public Gender GenderGuide { get; set; }//זכר או נקבה
        //public string ActivityName { get; set; }//שם הפעילות
        public bool Status { get; set; } = true;//סטטוס מדריך
        public List<Activity> GuideActivities { get; set; }//רשימת פעילויות של המדריך
    }
}
