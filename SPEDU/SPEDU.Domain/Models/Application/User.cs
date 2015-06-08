using SPEDU.Domain.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SPEDU.Domain.Models.Application
{
    public class User : BaseModel
    {
        public User()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            DeletedDate = DateTime.Now;
            IsDelete = false;
        }

        [Key]
        [Required]
        [Display(AutoGenerateField = false)]
        public Int32 UserId { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        [Display(Name = "User Name")]
        [MaxLength(100)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(64)]
        public byte[] PasswordHash { get; set; }

        [Required]
        [MaxLength(128)]
        public byte[] PasswordSalt { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [MaxLength(200)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string Comment { get; set; }

        [Display(Name = "Approved?")]
        public bool IsApproved { get; set; }

        [Display(Name = "Last Login Date")]
        public DateTime? LastLoginDate { get; set; }

        [Display(Name = "Last Activity Date")]
        public DateTime? LastActivityDate { get; set; }

        [Display(Name = "Last Password Change Date")]
        public DateTime LastPasswordChangeDate { get; set; }

        //public bool IsLoggedIn { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
