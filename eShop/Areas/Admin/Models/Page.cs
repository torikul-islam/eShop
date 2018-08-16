using eShop.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace eShop.Areas.Admin.Models
{
    public class Page
    {

        public int Id { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        [MaxLength(30)]
        public string Slug { get; set; }

        [AllowHtml]
        [StringLength(int.MaxValue, MinimumLength =3)]
        public string Body { get; set; }
        public int Sorting { get; set; }
        public bool HasSidebar { get; set; }

       
        
       
    }
}