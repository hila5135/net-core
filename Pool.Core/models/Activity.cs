namespace Pool.Core.models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }//שם הפעילות
        public TimeSpan BeginHour { get; set; }//שעת התחלה
        public TimeSpan EndHour { get; set; }//שעת סיום
        public Day ActivityDay { get; set; }//יום הפעילות
        public bool Status { get; set; } = true;//סטטוס פעילות
        public int GuideId { get; set; }
        public Guide Guide { get; set; }// מדריך של הפעילות
        public List<Swimmer> ActivitySwimmers { get; set; }//רשימת שוחים של הפעילות


    }
}
