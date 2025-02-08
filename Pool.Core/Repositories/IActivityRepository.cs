using Pool.Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Core.Repositories
{
    public interface IActivityRepository
    {
        public Task<List<Activity>> GetAllAsync();
        public Task<Activity> GetByIdAsync(int id);
        public Task<List<Activity>> GetActivitiesByDayAsync(Day activityDay);

        public Task<Activity> PostAsync(Activity activity);
        public Task<Activity> PutAsync(int id, Activity activity);  
        public Task<Activity> PutStatusAsync(int id, bool status);
        public Task DeleteAsync(int id);

    }
}
