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
using Microsoft.EntityFrameworkCore;

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

        [Microsoft.AspNetCore.Mvc.HttpGet("{id}", Name = "GetContact")]
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
        public IActionResult Post([Microsoft.AspNetCore.Mvc.FromBody]Contact contact)
        {
            if (contact == null)
            {
                return BadRequest();
            }

            try
            {
                _context.Contact.Add(contact);
                _context.SaveChanges();
                return CreatedAtRoute("GetContact", new { id = contact.ContactId }, contact);

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        [Microsoft.AspNetCore.Mvc.HttpPut("{id}")]
        public IActionResult Put(Guid id, [Microsoft.AspNetCore.Mvc.FromBody]Contact contact)
        {
            if (contact == null || contact.ContactId != id)
            {
                return BadRequest();
            }

            if (_context.Contact.AsNoTracking().FirstOrDefault(c=>c.ContactId == id) == null)
            {
                return NotFound();
            }


            try
            {
                var entry = _context.Entry(contact);
                entry.State = EntityState.Modified;
                _context.SaveChanges();
                return new NoContentResult();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // DELETE api/values/5
        [Microsoft.AspNetCore.Mvc.HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var contact = _context.Contact.FirstOrDefault(c => c.ContactId == id);

            if (contact == null)
            {
                return NotFound();
            }

            _context.Contact.Remove(contact);
            _context.SaveChanges();
            return new NoContentResult();

        }
    }
}
