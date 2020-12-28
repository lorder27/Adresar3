using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adresar3.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string thisUser { get; set; }
    }
}