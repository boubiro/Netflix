﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Netflix.Domain.Models.UserContext;
using Netflix.Services;

namespace Netflix.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PlansController : ControllerBase
    {
        private readonly IPlanService _planService;

        public PlansController(IPlanService planService)
        {
            _planService = planService;
        }

        // GET: api/<controller>
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IEnumerable<Plan>), 200)]
        public async Task<IEnumerable<Plan>> GetPlans()
        {
            return await _planService.GetAllPlans();
        }
    }
}