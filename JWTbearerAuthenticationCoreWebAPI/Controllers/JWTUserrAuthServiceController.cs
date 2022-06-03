using JWTbearerAuthenticationCoreWebAPI.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWTbearerAuthenticationCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class JWTUserrAuthServiceController : ControllerBase
    {
        private readonly IJwtAuthenticationManager _jwtAuthenticationManager;

        private readonly AppDBContext _context;
        private IConfiguration _config;
        public JWTUserrAuthServiceController(AppDBContext context, IConfiguration config, IJwtAuthenticationManager jwtAuthenticationManager)
        {
            _config = config;
            _context = context;
            _jwtAuthenticationManager = jwtAuthenticationManager;
        }
        public static List<Product> ProductsList = new List<Product>()
        {
        new Product(){ ProductCode=1,ProductName="Speakers",ProductPrice=30000.00m},
        new Product(){ ProductCode=2,ProductName="Desktops",ProductPrice=30000.00m},
        new Product(){ ProductCode=3,ProductName="Laptops",ProductPrice=25000.00m},
        new Product(){ ProductCode=4,ProductName="Gaming PC's",ProductPrice=60000.00m},
        new Product(){ ProductCode=5,ProductName="Servers",ProductPrice=100000.00m},
        new Product(){ ProductCode=6,ProductName="Tablet",ProductPrice=5000.00m},
        new Product(){ ProductCode=7,ProductName="PC's Monitors",ProductPrice=5000.00m},
        new Product(){ ProductCode=8,ProductName="Memory",ProductPrice=2500.00m},
        new Product(){ ProductCode=9,ProductName="Printers",ProductPrice=4000.00m},
        new Product(){ ProductCode=10,ProductName="Projectors",ProductPrice=30000.00m}
        };

        // GET: api/<JWTUserrAuthServiceController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductsList.ToList();    //new string[] { "value1", "value2" };
        }

       
       

        // GET api/<JWTUserrAuthServiceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JWTUserrAuthServiceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<JWTUserrAuthServiceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JWTUserrAuthServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
