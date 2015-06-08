using SPEDU.Domain.BaseModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace SPEDU.Domain.Models.Application
{
    public class UserProfile : BaseModel
    {
        public UserProfile()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            DeletedDate = DateTime.Now;
            IsDelete = false;
        }

        [Key]
        [Required]
        public int UserProfileId { get; set; }

        [Display(Name = "First Name")]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Display(Name = "Sur Name")]
        [MaxLength(100)]
        public string SurName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Address")]
        [MaxLength(200)]
        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        [MaxLength(50)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Mobile Number")]
        [MaxLength(50)]
        public string MobileNumber { get; set; }

        [Display(Name = "Photo or Logo")]
        public Byte[] Photo { get; set; }

        [Display(Name = "Photo File Name With Extension")]
        [StringLength(256)]
        public virtual String PhotoFileName { get; set; }

        [Display(Name = "Photo File Size")]
        public virtual Int64? PhotoFileSize { get; set; }

        //one to one relationship with user
        public string UserName { get; set; }
        public User User { get; set; }
    }
}
