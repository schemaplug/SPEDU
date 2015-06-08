using SPEDU.Domain.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SPEDU.Domain.Models.Application
{
    public class Role : BaseModel
    {
        public Role()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            DeletedDate = DateTime.Now;
            IsDelete = false;
        }

        //[Key]
        //public virtual Guid RoleId { get; set; }

        [Key]
        [Display(Name = "Role Name")]
        [Required]
        [MaxLength(100)]
        public string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
