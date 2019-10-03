using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNetCoreWebDapper.Models;
using ASPNetCoreWebDapper.DAL;

namespace ASPNetCoreWebDapper.Controllers
{
    public class HomeController : Controller
    {
        private readonly GroupMeetingService groupMetting = new GroupMeetingService();
        private readonly RomSever romService = new RomSever();
        [HttpGet]
        public IActionResult Index()
        {
            var data = groupMetting.GetGroupMeetings();
            return View(data);
        }
        [HttpGet]
       public IActionResult Create()
        {
            ViewBag.Roms = GetRoms();
            return View();
        }
        [HttpPost]
        public IActionResult Create( GroupMettingCreate model)
        {
            var createResult = groupMetting.AddGroupMeeting(new GroupMeeting()
            {
                ProjectName = model.ProjectName,
                GroupMeetingLeadName = model.GroupMeetingLeadName,
                TeamLeadName = model.TeamLeadName,
                Description = model.Description,
                GroupMeetingDate = model.GroupMeetingDate,
                RomID= model.RomID
            });
           
            if ( createResult> 0)
            {
                TempData["Message"] = "Employee has been added successfully.";
            }
            else
            {
                TempData["Message"] = "Something went wrong, please contact administrator.";
            }
            ModelState.Clear();
            ViewBag.Roms =GetRoms();
            return View(new GroupMettingCreate() { GroupMeetingDate= DateTime.Now});
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var delete = groupMetting.GetGroupMeetingById(id);
            //delete.
            return View(delete);
        }
        [HttpPost]
        public IActionResult Delete(int id, GroupMeeting groupMeeting)
        {
            var deleteResult = groupMetting.GetGroupMeetingById(id);
           
            if (groupMetting.DeleteGroupMeeting(id) > 0)
            {
                return RedirectToAction("Index");
            }
            return View(deleteResult); 
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var group = groupMetting.GetGroupMeetingById(id);
            var editResult = new GroudMettingEdit()
            {
                ProjectName = group.ProjectName,
                GroupMeetingLeadName = group.GroupMeetingLeadName,
                TeamLeadName = group.TeamLeadName,
                Description = group.Description,
                GroupMeetingDate = group.GroupMeetingDate
            };
            if (editResult == null)
            {
                return NotFound();
            }
               
            return View(editResult);
        }
        [HttpPost]
        public IActionResult Edit(int id, GroupMeeting group)
        {
            if (id != group.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                groupMetting.UpdateGroupMeeting(group);
                return RedirectToAction("Index");
            }
            return View(group);
        }
        public IActionResult Details(int id)
        {
            var group = groupMetting.GetGroupMeetingById(id);

            return View(group);
        }
        private List<RomView> GetRoms()
        {
            var response = romService.GetRoms();
            var data = response.Select(s => new RomView()
            {
                RomName = s.RomName,
                RomID = s.RomID
            }).ToList();
            return data;
        }
    }
}
