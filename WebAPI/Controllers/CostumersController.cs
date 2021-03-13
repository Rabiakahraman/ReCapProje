using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostumersController : ControllerBase
    {
        ICostumerService _costumerservice;

        public CostumersController(ICostumerService costumerservice)
        {
            _costumerservice = costumerservice;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _costumerservice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        
        }
        [HttpGet("getbyıd")]
        public IActionResult GetById(int costumerId)
        {
            var result = _costumerservice.GetById(costumerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Costumer costumer)
        {
            var result = _costumerservice.Add(costumer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Costumer costumer)
        {
            var result = _costumerservice.Delete(costumer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Costumer costumer)
        {
            var result = _costumerservice.Update(costumer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




    }
}
