﻿using Angular2MultiSPA.Data;
using Angular2MultiSPA.Helpers;
using Angular2MultiSPA.Models;
using Angular2MultiSPA.ViewModels;
using AspNet.Security.OAuth.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Angular2MultiSPA.Api
{

    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private NorthwindContext _context;

        public EmployeeController(NorthwindContext context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: api/values
        [Authorize(ActiveAuthenticationSchemes = OAuthValidationDefaults.AuthenticationScheme)]
        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                // TODO: create a more useful view model that carries request status and error messages, along with the data
                return null;// BadRequest();
            }

            // TODO: add automapper
            var employees = _context.Employees.Select(a => new Employee
            {
                Id = a.EmployeeId,
                FirstName = a.FirstName,
                LastName = a.LastName,
                Image = a.Photo.ConvertToBase64()
            });

            return employees;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}