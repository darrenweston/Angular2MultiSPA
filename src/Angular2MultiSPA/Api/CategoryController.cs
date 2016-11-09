﻿using Angular2MultiSPA.Data;
using Angular2MultiSPA.Helpers;
using Angular2MultiSPA.Models;
using Angular2MultiSPA.ViewModels;
using AspNet.Security.OAuth.Validation;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular2MultiSPA.Api
{

    [Route("api/[controller]")]
    public class CategoryController : BaseController
    {
        public CategoryController(IMediator mediator, NorthwindContext context, UserManager<ApplicationUser> userManager) : base(mediator, context, userManager)
        {
        }

        // GET: api/values
        [Authorize(ActiveAuthenticationSchemes = OAuthValidationDefaults.AuthenticationScheme)]
        [HttpGet]
        public async Task<IEnumerable<Category>> Get()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                // TODO: create a more useful view model that carries request status and error messages, along with the data
                return null;// BadRequest();
            }

            return _mediator.Send(new GetAllCategoriesQuery(user));
            //var categories = _context.Categories.Select(a => new Category
            //{
            //    Id = a.CategoryId,
            //    Name = a.CategoryName,
            //    Description = a.Description,
            //    Image = a.Picture.ConvertToBase64()
            //});

            //return categories;
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
