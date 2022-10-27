using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using postApi.Models;

namespace postApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        [HttpGet("SayHello")]
        //[Route("SayHello")]
        public string SayHello(SayHelloModel name)//call the say hello model
        {
            return "SayHello " + name.userName + name.lastName;
        }
        [HttpGet("Adding")]

        public string AddNumbers(AddingModel number)
        {
            return $"The sume of your numbers is: {number.numberOne + number.numberTwo}";
        }
    }

}