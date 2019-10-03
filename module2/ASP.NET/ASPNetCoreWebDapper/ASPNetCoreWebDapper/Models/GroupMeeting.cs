﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreWebDapper.Models
{
    public class GroupMeeting
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Project Name!")]
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "Enter Group Lead Name!")]
        public string GroupMeetingLeadName { get; set; }

        [Required(ErrorMessage = "Enter Team Lead Name!")]
        public string TeamLeadName { get; set; }

        [Required(ErrorMessage = "Enter Description!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Enter Group Meeting Date!")]
        public DateTime GroupMeetingDate { get; set; }
        public int RomID { get; set; }
    }
}