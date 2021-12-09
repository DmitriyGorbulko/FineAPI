using AvtoAPI.Entities;
using AvtoAPI.Repositories;
using AvtoAPI.Services.Abstracts;
using FineAPI.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Controllers
{
    public class TypeFineController : ControllerBase
    {
        private readonly IFineService _typeFineService;

        public TypeFineController(ITypeFineService typeFineService)
        {
            _typeFineService = typeFineService;
        }


        [HttpGet]
        public async Task<IActionResult> GetTypeFine([FromQuery] int id)
        {
            return Ok(await _typeFineService.GetFineById(id));
        }
    }
}