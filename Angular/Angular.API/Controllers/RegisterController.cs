using Angular.Business.Interfaces;
using Angular.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IRegisterBusiness _registerBusiness;
        public RegisterController(IRegisterBusiness regBusiness)
        {
            _registerBusiness = regBusiness;

        }
        [HttpGet]
        public async Task<IActionResult> GetAllRegisters()
        {
            var registers = await _registerBusiness.GetAllRegisters();
            return Ok(registers);
        }

        [HttpPost]
        public async Task<IActionResult> Post(RegisterVM reg)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(reg);
            }
            var result =  await _registerBusiness.InsertRegister(reg);
            if (result is not null)
                return Ok(result);
            else
                return NotFound(result);
        }
    }
}
