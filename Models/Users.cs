﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class Users
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [DisplayName("First name")]
        [Required]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        [Required]
        public string LastName { get; set; }

        [DisplayName("Date of creation")]
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateCreation { get; set; }

        [DisplayName("Id of the creator")]
        ///[Required]
        public string IdCreator { get; set; }

        [DisplayName("Date of last change")]
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateChange { get; set; }

        [DisplayName("Id of the user that did the last change")]
        ///[Required]
        public string IdChange { get; set; }
    }
}
