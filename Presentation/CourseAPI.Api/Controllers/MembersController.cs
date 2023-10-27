using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseAPI.Application.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CourseAPI.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class MembersController : ControllerBase
    {

        private readonly IMemberService _memberService;

        public MembersController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var members = _memberService.GetMembers();
            return Ok(members);
        }
    }
}
