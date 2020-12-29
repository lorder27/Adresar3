using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Adresar3.Data;
using Adresar3.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Adresar3.Authorization;
using Microsoft.AspNetCore.Http;

namespace Adresar3.Controllers
{
    [Authorize(Roles = "Admin, ContactAdministratorsRole, ContactAdministrators")]
    public class AdminController : Controller
    {
        // GET: AdminController
        public IList<Contact> Contact { get; set; }
        private readonly ContactContext _context;
        private readonly UserManager<ApplicationUser> userManager;

        // Populate your users and store it in the ViewBag (or other storage)


public AdminController(ContactContext context)
        {
            this.userManager = userManager;
            _context = context;
        }
        public async Task<IActionResult> Index(string searchString, string sortOrder)
        {



            var contacts = from m in _context.Contact
                           select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                contacts = contacts.Where(s => s.Name.Contains(searchString));
            }


            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            
            
            switch (sortOrder)
            {
                case "name_desc":
                    contacts = contacts.OrderBy(m => m.Username);
                    break;
                
            }




            return View(await contacts.ToListAsync());



            //return View(await contacts.ToListAsync());
        }

        // GET: AdminController/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .FirstOrDefaultAsync(m => m.OwnerID == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .FirstOrDefaultAsync(m => m.OwnerID == id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ContactId,OwnerID,Name,Address,City,State,Zip,Email,ContactNum,ContactNum1,ContactNum2,ContactNum3,ContactNum4,ContactNum5,Status,Role")] Contact contact)
        {
            if (id != contact.OwnerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactExists(contact.OwnerID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        // GET: AdminController/Delete/5


        // POST: AdminController/Delete/5

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact
                .FirstOrDefaultAsync(m => m.OwnerID == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var contact = await _context.Contact
                .FirstOrDefaultAsync(m => m.OwnerID == id);
            _context.Contact.Remove(contact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        
        
        public ActionResult ListUsers()
        {
            ApplicationDbContext UsersContext = new ApplicationDbContext();
            UsersContext.Users.ToList(); // Exception
            //return View(UsersContext);


            var users = userManager.Users;
            return View(users);
        }

        private bool ContactExists(string id)
        {
            return _context.Contact.Any(e => e.OwnerID == id);
        }


    }
}

