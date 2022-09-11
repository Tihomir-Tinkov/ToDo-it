using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class Tasks
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [DisplayName("Id of the List")]
        [Required]
        public int IdList { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [DisplayName("Is complete")]
        [Required]
        public bool IsComplete { get; set; }

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
