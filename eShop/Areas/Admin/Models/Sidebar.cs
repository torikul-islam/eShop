using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eShop.Areas.Admin.Models
{
    public class Sidebar
    {
        public int Id { get; set; }

        [AllowHtml]
        public string Body { get; set; }

    }
}