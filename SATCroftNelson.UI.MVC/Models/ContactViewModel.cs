using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SATCroftNelson.UI.MVC.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Name is a required field.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is a required field.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Subject { get; set; }

        [Required(ErrorMessage = "Message is a required field.")]
        [UIHint("MultilineText")]
        public string Message { get; set; }
    }
}