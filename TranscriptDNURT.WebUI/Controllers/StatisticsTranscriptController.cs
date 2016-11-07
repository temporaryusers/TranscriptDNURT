﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using TranscriptDNURT.WebUI.Models;
using TranscriptsDNURT.Domain.Context;

namespace TranscriptDNURT.WebUI.Controllers
{
    public class StatisticsTranscriptController : Controller
    {
        private EFDbContext db = new EFDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public List<TranscriptModel> GetTranscript()
        {
            List<TranscriptModel> data = new List<TranscriptModel>();

            foreach (var item in db.Transcripts.ToList())
            {
                data.Add(new TranscriptModel
                {
                    Mark = item.Mark.Value,
                    Semester = item.Semester.Value,
                    StudentName = item.Student.Name,
                    SubjectName = item.Subject.Name,
                    GroupName = item.Student.Group.Name,
                    TeacherName = item.Teacher.Name,
                    TypeControlName = item.TypeControl.Name,
                    Year = item.Year.Value
                });
            }

            return data;
        }

        public string GetData()
        {
            return JsonConvert.SerializeObject(GetTranscript());
        }
    }
}