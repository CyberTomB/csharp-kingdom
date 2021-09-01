using System;
using System.Collections.Generic;
using csharp_kingdom.Models;
using csharp_kingdom.Services;
using Microsoft.AspNetCore.Mvc;

namespace csharp_kingdom.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CastlesController : ControllerBase
    {
        private readonly CastlesService _castlesService;
        public CastlesController(CastlesService castlesService)
        {
            _castlesService = castlesService;
        }

        // GET ALL
        [HttpGet]
        public ActionResult<IEnumerable<Castle>> Get()
        {
            try
            {
                IEnumerable<Castle> castles = _castlesService.Get();
                return Ok(castles);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        // GET By ID
        [HttpGet("{id}")]
        public ActionResult<Castle> Get(string id)
        {
            try
            {
                Castle castle = _castlesService.Get(id);
                return Ok(castle);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}