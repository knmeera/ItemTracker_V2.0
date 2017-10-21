using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassDemo.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        //public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        //public string ClientId { get; set; }
        //public string CustomerName { get; set; }
        //public string CustomerEmail { get; set; }
        //public string CustomerContactName { get; set; }
        //public string CustomerPrimaryEmail { get; set; }
        //public string CustomerSecondaryEmail { get; set; }
        //public string PricingModel { get; set; }
        //public bool IsInternalProject { get; set; }
        //public string Assigned { get; set; }
        //public string platform { get; set; }
        //public string Domain { get; set; }
        //public string Technology { get; set; }
        //public  DateTime StartDate { get; set; }
        //public DateTime EndDate { get; set; }
        //public string RequiredResoures { get; set; }
        //public string Description { get; set; }
        //public string Status { get; set; }
        //public string Enable { get; set; }
        //public string Disable { get; set; }


        public virtual ICollection<TrackerItem> TrackerItems { get; set; }
    }
}