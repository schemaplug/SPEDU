using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SPEDU.Domain.Models.Application
{
    class AppMenu
    {
        [Key]
        public int MenuId { get; set; }

        [DisplayName("Name: ")]
        [Required(ErrorMessage = "Menu Name is required")]
        [MaxLength(200)]
        public string MenuName { get; set; }

        [DisplayName("Caption: ")]
        public string MenuCaption { get; set; }

        [DisplayName("Caption Image: ")]
        public string MenuCaptionBng { get; set; }

        [DisplayName("Icon: ")]
        public string MenuIcon { get; set; }

        [DisplayName("Page Url: ")]
        public string PageUrl { get; set; }

        [DisplayName("Serial No: ")]
        public int SerialNo { get; set; }

        [DisplayName("Order No: ")]
        public int OrderNo { get; set; }

        [DisplayName("Parent Menu: ")]
        //[Required(ErrorMessage = "Select Parent Menu.")]
        //[Range(1, long.MaxValue, ErrorMessage = "Select Parent Menu.")]
        public int ParentMenuId { get; set; }
        [DisplayName("Parent Menu Name")]
        public string ParentMenuName { get; set; }
        [ForeignKey("ParentMenuId")]
        public virtual AppMenu ParentAppMenu { get; set; }

    }
}
