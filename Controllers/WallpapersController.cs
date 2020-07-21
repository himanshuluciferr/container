﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WallpapeRAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WallpapersController : ControllerBase
    {
        public string[] getData()
        {
            return new string[] { "Welcome", "Good Morning" };
        }
    }
}
