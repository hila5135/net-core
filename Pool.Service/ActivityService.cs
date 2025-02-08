using Pool.Core.Repositories;
using Pool.Core.models;
using Pool.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool.Core.Services;
using AutoMapper;
using Pool.Core.Dtos;

namespace Pool.Service
{
    public class ActivityService : IActivityService
    {

        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;


        public ActivityService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<List<Activity>> GetAllAsync()
        {
            return await _repositoryManager.Activities.GetAllAsync();
        }
        public async Task<Activity> GetByIdAsync(int id)
        {
            return await _repositoryManager.Activities.GetByIdAsync(id);

        }
        public async Task<List<Activity>> GetActivitiesByDayAsync(Day activityDay)
        {
            return await _repositoryManager.Activities.GetActivitiesByDayAsync(activityDay);
        }
        public async Task<Activity> PostAsync(ActivityPostDTO activity)
        {
            var activityMap = _mapper.Map<Activity>(activity);
            return await _repositoryManager.Activities.PostAsync(activityMap);
        }

        public async Task<Activity> PutAsync(int id, ActivityPutDTO activity)
        {
            var activityMap = _mapper.Map<Activity>(activity);
            return await _repositoryManager.Activities.PutAsync(id, activityMap);
        }

        public async Task<Activity> PutStatusAsync(int id, bool status)
        {
            return await _repositoryManager.Activities.PutStatusAsync(id, status);
        }

        public async Task DeleteAsync(int id)
        {
            await _repositoryManager.Activities.DeleteAsync(id);
        }




    }
}
