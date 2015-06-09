using System;
using SPEDU.Domain.BaseModels;
using System.ComponentModel.DataAnnotations;

namespace SPEDU.Domain.Models.Application
{
    public class AppDefaultSetting : BaseModel
    {
        public AppDefaultSetting()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            DeletedDate = DateTime.Now;
            IsDelete = false;
        }

        [Key]
        public virtual Guid RoleId { get; set; }

        [Display(Name = "Name")]
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Display(Name = "Key")]
        [Required]
        [MaxLength(100)]
        public string Key { get; set; }

        [Display(Name = "Key")]
        [Required]
        [MaxLength(200)]
        public string Value { get; set; }
    }
}
