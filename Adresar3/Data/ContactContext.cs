using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Adresar3.Models;

namespace Adresar3.Data
{
    public class ContactContext :DbContext
    {
        public ContactContext (DbContextOptions<ContactContext> options)
            : base(options)
        {

        }

        public DbSet<Contact> Contact { get; set; }
    }
}
