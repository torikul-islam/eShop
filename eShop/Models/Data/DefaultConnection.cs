using eShop.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eShop.Models.Data
{
    public class DefaultConnection : DbContext 
    {
        public DbSet<Page> Pages { get; set; }
        public DbSet<Sidebar> Sidebars { get; set; }

    }
}