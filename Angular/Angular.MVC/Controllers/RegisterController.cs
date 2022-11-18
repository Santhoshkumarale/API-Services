using Angular.Business.Interfaces;
using Angular.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular.MVC.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IRegisterBusiness _registerBusiness;
        public RegisterController(IRegisterBusiness regBusiness)
        {
            _registerBusiness = regBusiness;
        }
        public async Task<IActionResult> Index()
        {
            var list = await _registerBusiness.GetAllRegisters();
            return View(list);
        }
        [HttpGet]

        public IActionResult InsertData()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> InsertData(RegisterVM reg)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            
            var register = await _registerBusiness.InsertRegister(reg);
            if (register is not null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
