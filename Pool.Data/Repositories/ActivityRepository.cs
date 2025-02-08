using Microsoft.EntityFrameworkCore;
using Pool.Core.models;
using Pool.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Data.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly DataContext _context;

        public ActivityRepository(DataContext context)
        {
            _context = context;
        }
        public  async Task<List<Activity>> GetAllAsync()
        {
            return await _context.activities.Include(a=>a.Guide).Include(ac=>ac.ActivitySwimmers).ToListAsync();
        }
        public async Task<Activity> GetByIdAsync(int id)
        {
            Activity a = await _context.activities.SingleOrDefaultAsync(act => act.Id == id);
            if (a != null)
                return a;
            return null;
        }
        public async Task<List<Activity>> GetActivitiesByDayAsync(Day activityDay)
        {
            return  await _context.activities.Where(a => a.ActivityDay == activityDay).ToListAsync();
        }
        public async Task<Activity> PostAsync(Activity activity)
        {
            _context.activities.Add(activity);
            await _context.SaveChangesAsync(); 
            return activity;
        }
        public async Task<Activity> PutAsync(int id, Activity activity)
        {
            Activity a =await _context.activities.SingleOrDefaultAsync(act=> act.Id==id);
            if (a == null) return null;
            else
            {
                a.Name = activity.Name;
                a.BeginHour = new TimeSpan(activity.BeginHour.Hours, activity.BeginHour.Minutes, activity.BeginHour.Seconds);
                a.EndHour = new TimeSpan(activity.EndHour.Hours, activity.EndHour.Minutes, activity.EndHour.Seconds);
                a.ActivityDay = activity.ActivityDay;
                a.Guide = activity.Guide;
                a.ActivitySwimmers=activity.ActivitySwimmers;
            }
            return a;
        }
        public async Task<Activity> PutStatusAsync(int id, bool status)
        {
            Activity a =await _context.activities.SingleOrDefaultAsync(act => act.Id == id);
            if (a!=null)
                a.Status=status;
            return a;
        }
        public async Task DeleteAsync(int id)
        {
            var activity = await _context.activities.SingleOrDefaultAsync(act => act.Id == id);
            if (activity != null)
            {
                _context.activities.Remove(activity);
                await _context.SaveChangesAsync();
            }
        }

    }
}
