using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eShop.Areas.Admin.Models
{
    public class Page
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Body { get; set; }
        public int Sorting { get; set; }
        public int HasSidebar { get; set; }

    }
}