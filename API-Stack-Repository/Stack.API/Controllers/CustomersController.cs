using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stack.API.Controllers.Common;
using Stack.DTOs.Models;
using Stack.DTOs.Requests;
using Stack.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace Stack.API.Controllers
{
    [Route("api/Customers")]
    [ApiController]
    // [Authorize] // Require Authorization to access API endpoints . 
    public class CustomersController : BaseResultHandlerController<VehicleService>
    {
        public CustomersController(VehicleService _service) : base(_service)
        {

        }




    }
}
