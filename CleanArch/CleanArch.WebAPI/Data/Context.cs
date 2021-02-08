using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.WebAPI.Data
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions options)
        :base(options)
        {
            
        }
    }
}
