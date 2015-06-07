using System;

namespace SPEDU.Domain.BaseModels
{
    public class BaseViewModel
    {
        //public int Id { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public bool IsDelete { get; set; }

        public int DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }

        //ActionLink
        public string ActionLink { get; set; }
    }
}
