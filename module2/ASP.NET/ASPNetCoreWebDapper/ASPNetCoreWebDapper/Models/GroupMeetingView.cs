using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreWebDapper.Models
{
    public class GroupMeetingView
    {
        [Display(Name ="ID")]
        public int Id { get; set; }

        [Display(Name ="Project Name")]
        public string ProjectName { get; set; }

        [Display(Name = "Group Lead Name")]
        public string GroupMeetingLeadName { get; set; }

       [Display(Name = "Team Lead Name")]
        public string TeamLeadName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Group Date")]
        public DateTime GroupMeetingDate { get; set; }
        public string RomName { get; set; }
    }
}
