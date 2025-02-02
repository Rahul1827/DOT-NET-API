﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace AspNetWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsAPIController : ControllerBase
    {
        public List<string> Fruits = new List<string>()
        {
            "Apple",
            "Banana",
            "Grapes",
            "Cherry",
            "Strawberry"
        };

        [HttpGet]
        public List<string> GetFruits()
        { 
          return Fruits;
        }

        [HttpGet ("{id}")]
        public string GetFruitsById(int id)
        {
            return Fruits.ElementAt (id);
        }
    }
}
