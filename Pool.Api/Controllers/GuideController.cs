using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System;
using Pool.Core.Services;
using Pool.Core.models;
using Pool.Service;
using System.Diagnostics;
using System.Xml.Linq;
using Pool.Core.Dtos;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pool.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuideController : ControllerBase
    {

        private readonly IGuideService _guideService;
        public GuideController(IGuideService guideService)
        {
           _guideService = guideService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_guideService.GetAll());
        }

        [HttpGet("{id:int}")]
        public ActionResult Get(int id)
        {
            return Ok(_guideService.GetById(id));
        }

        [HttpGet("guide/{name}/activities")]
        public ActionResult Get(string name)
        {
            return Ok(_guideService.GetGuideActivities(name));
        }

        [HttpPost]
        public ActionResult Post([FromBody] GuidePostDTO guide)
        {
           Guide newGuide= _guideService.Post(guide);
            return Ok(newGuide);
        }


        [HttpPut("{id}")]
       
        public ActionResult Put(int id, [FromBody] GuidePutDTO guide)
        {
           Guide updateGuide= _guideService.Put(id, guide);
            if (updateGuide == null)
            {
                return NotFound();
            }
            return Ok(updateGuide);
        }


        [HttpPut("{id}/status")]
        public ActionResult Put(int id, bool status)
        {
           Guide updateGuide=_guideService.PutStatus(id, status);
            if (updateGuide == null)
            {
                return NotFound();
            }
            return Ok(updateGuide);
        }

    }
}

