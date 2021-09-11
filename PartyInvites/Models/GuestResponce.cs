using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponce
    {
        //Указание ФИО
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }

        //Указание email
        [Required(ErrorMessage ="Please enter your email adress")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Please enter your email adress")]
        public string Email { get; set; }

        //Указание телефона
        [Required(ErrorMessage ="Please enter your phone number")]
        public string Phone { get; set; }

        //Решение о посещении
        [Required(ErrorMessage ="Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }

    }
}
