using Microsoft.AspNetCore.Mvc;
using System;
using Pool.Core;
using Pool.Core.models;
using Pool.Service;
using Pool.Core.Services;
using AutoMapper;
using Pool.Core.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pool.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {

        private readonly IActivityService _activityService;

        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var activities = await _activityService.GetAllAsync();
            return Ok(activities);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var activity = await _activityService.GetByIdAsync(id);
            return Ok(activity);
        }

        [HttpGet("{activityDay}")]
        public async Task<ActionResult> GetByDayAsync(Day activityDay)
        {
            var activities = await _activityService.GetActivitiesByDayAsync(activityDay);
            return Ok(activities);
        }
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] ActivityPostDTO activity)
        {
            Activity newActivity = await _activityService.PostAsync(activity);
            return Ok(newActivity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] ActivityPutDTO activity)
        {

            Activity updateActivity = await _activityService.PutAsync(id, activity);
            if (updateActivity == null)
            {
                return NotFound();
            }
            return Ok(updateActivity);

        }

        [HttpPut("{id}/status")]
        public async Task<ActionResult> PutAsync(int id, bool status)
        {
            Activity updateActivity = await _activityService.PutStatusAsync(id, status);
            if (updateActivity == null)
            {
                return NotFound();
            }
            return Ok(updateActivity);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var activity = await _activityService.GetByIdAsync(id);
            if (activity == null)
            {
                return NotFound();
            }
            await _activityService.DeleteAsync(id);
            return NoContent();
        }
    }
}
