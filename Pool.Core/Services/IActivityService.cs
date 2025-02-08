using Pool.Core.Dtos;
using Pool.Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Core.Services
{
    public interface IActivityService
    {
       public Task<List<Activity>> GetAllAsync();
       public Task<Activity> GetByIdAsync(int id);
       public Task<List<Activity>> GetActivitiesByDayAsync(Day activityDay);
        public Task<Activity> PostAsync(ActivityPostDTO activity);
       public Task<Activity> PutAsync(int id, ActivityPutDTO activity);
       public Task<Activity> PutStatusAsync(int id, bool status);
       public Task DeleteAsync(int id);


    }
}
