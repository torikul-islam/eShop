using eShop.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Net.WebRequestMethods;

namespace eShop.Areas.Admin.Models
{
    //public class TitleSlugExistsOrNot : ValidationAttribute
    //{
    //    protected DefaultConnection db = new DefaultConnection();
    //    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //    {
    //       // validationContext.ObjectInstance.GetType().GetProperty(AdditionalFields);
    //        if(db.Pages.Any(t => t.Title == (string)value))
    //        {
    //            return new ValidationResult("The Title already exist");
    //        }
    //        if (db.Pages.Any(t => t.Slug == (string)value))
    //        {
    //            return new ValidationResult("The Slug already exist");
    //        }

    //        return ValidationResult.Success;
    //    }

    //}
    
}
