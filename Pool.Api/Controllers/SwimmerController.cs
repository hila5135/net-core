using Microsoft.AspNetCore.Mvc;
using System;
using Pool.Core;
using Pool.Core.models;
using Pool.Service;
using Pool.Core.Services;
using Pool.Core.Dtos;
using System.Diagnostics;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pool.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SwimmerController : ControllerBase
    {

        private readonly ISwimmerService _swimmerService;
        public SwimmerController(ISwimmerService swimmerService)
        {
           _swimmerService = swimmerService;
        }

        [HttpGet]
        public async Task< ActionResult> Get()
        {
            return Ok(_swimmerService.GetAllAsync());
        }

        [HttpGet("{id:int}")]
        public ActionResult Get(int id)
        {
            return Ok(_swimmerService.GetByIdAsync(id));
        }

        [HttpGet("{genderSwimmer}")]
        public  ActionResult Get(Gender genderSwimmer)
        {
            return Ok(_swimmerService.GetSwimmersByGenderAsync(genderSwimmer));
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] SwimmerPostDTO swimmer)
        {
           Swimmer newSwimmer=await _swimmerService.PostAsync(swimmer);
            return Ok(newSwimmer);
        }
       
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] SwimmerPutDTO swimmer)
        {
            Swimmer updateSwimmer=await _swimmerService.PutAsync(id, swimmer);
            if (updateSwimmer == null)
            {
                return NotFound();
            }
            return Ok(updateSwimmer);
        }
            
    [HttpPut("{id}/status")]
        public async Task< ActionResult> Put(int id, bool status)
        {
            Swimmer updateSwimmer =await _swimmerService.PutStatusAsync(id, status);
            if (updateSwimmer == null)
            {
                return NotFound();
            }
            return Ok(updateSwimmer);
        }

    }
}
