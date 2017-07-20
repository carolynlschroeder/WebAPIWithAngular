using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using ContactsAPI.Entities;
using Microsoft.ApplicationInsights.AspNetCore.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactsAPI.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly ContactsContext _context;

        public ContactsController(ContactsContext context)
        {
            _context = context;
        }
        
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IActionResult Get()
        {
            var contacts = _context.Contact.ToList();
            return Ok(contacts);

        }

        [Microsoft.AspNetCore.Mvc.HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var contact = _context.Contact.ToList().FirstOrDefault(c => c.ContactId == id);
            if (contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public ActionResult Post([Microsoft.AspNetCore.Mvc.FromBody]Contact contact)
        {
            try
            {
                _context.Set<Contact>().Add(contact);
                _context.SaveChanges();
                var newContact = _context.Contact.ToList().FirstOrDefault(c => c.ContactId == contact.ContactId);
                return Created(Request.GetUri(), contact);

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // PUT api/values/5
        [Microsoft.AspNetCore.Mvc.HttpPut("{id}")]
        public void Put(int id, [Microsoft.AspNetCore.Mvc.FromBody]string value)
        {
        }

        // DELETE api/values/5
        [Microsoft.AspNetCore.Mvc.HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
