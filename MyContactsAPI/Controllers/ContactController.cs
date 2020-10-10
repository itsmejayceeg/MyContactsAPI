using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mca.core.Services;
using mca.core.ViewModels;

namespace MyContactsAPI.Controllers
{
    [Route("/api/v1")]
    [ApiController]
    public class ContactController : Controller
    {
        private readonly IContactService _contact;

        public ContactController(IContactService contact)
        {
            _contact = contact;
        }

        [Route("contact")]
        [HttpPost]
        public async Task<IActionResult> CreateStudent([FromBody] CreateContactDTO obj)
        {
            var response = await _contact.CreateContact(obj);

            if (response.statusCode == 400)
            {
                return BadRequest(response);
            }
            else if (response.statusCode == 401)
            {
                return Unauthorized(response);
            }

            return Ok(response);
        }

        [Route("contact/{contactId}")]
        [HttpGet]
        public async Task<IActionResult> GetContactDetails([FromRoute] int contactId)
        {
            var response = await _contact.GetContactDetails(contactId);

            if (response.statusCode == 400)
            {
                return BadRequest(response);
            }
            else if (response.statusCode == 401)
            {
                return Unauthorized(response);
            }

            return Ok(response);
        }

        [Route("contact/{contactId}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteContact([FromRoute] int contactId)
        {
            var response = await _contact.DeleteContact(contactId);

            if (response.statusCode == 400)
            {
                return BadRequest(response);
            }
            else if (response.statusCode == 401)
            {
                return Unauthorized(response);
            }

            return Ok(response);
        }

        [Route("contact")]
        [HttpGet]
        public async Task<IActionResult> ListContacts()
        {
            var response = await _contact.ListAllContacts();

            if (response.statusCode == 400)
            {
                return BadRequest(response);
            }
            else if (response.statusCode == 401)
            {
                return Unauthorized(response);
            }

            return Ok(response);
        }

        [Route("contact")]
        [HttpPut]
        public async Task<IActionResult> UpdateContact([FromBody] UpdateContactDTO obj)
        {
            var response = await _contact.UpdateContact(obj);

            if (response.statusCode == 400)
            {
                return BadRequest(response);
            }
            else if (response.statusCode == 401)
            {
                return Unauthorized(response);
            }

            return Ok(response);
        }
    }
}
