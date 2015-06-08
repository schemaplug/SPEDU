using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using SPEDU.Domain.BaseModels;

namespace SPEDU.Domain.Models.Application
{
    public class AppRight : BaseModel
    {
        public AppRight()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            DeletedDate = DateTime.Now;
            IsDelete = false;
        }

        [Key]
        public int RightId { get; set; }

        [DisplayName("Name: ")]
        [Required(ErrorMessage = "Right Name is required")]
        [MaxLength(200)]
        public string Name { get; set; }

        [DisplayName("Description: ")]
        [Required(ErrorMessage = "Description is required")]
        [MaxLength(200)]
        public string Description { get; set; }

    }
}
