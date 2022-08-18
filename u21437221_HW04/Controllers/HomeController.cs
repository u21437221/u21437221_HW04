using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21437221_HW04.Models;

namespace u21437221_HW04.Controllers
{
    public class HomeController : Controller
    {
        public static List<PersonalInfo> personalInfos = new List<PersonalInfo>();
        public ActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public ActionResult NGOApply()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NGOApply(string name, string surname, string idNumber, int cellNumber, int age, int jobType)
        {
            PersonalInfo newPerson = null;
            if (jobType == 1)
            {
                NGOApply newApply = (NGOApply)newPerson;
                newApply = new NGOApply(name, surname, idNumber, cellNumber, age, jobType.ToString());
                personalInfos.Add(newApply);
            }
            if (jobType == 2)
            {
                NGOApply newApply = (NGOApply)newPerson;
                newApply = new NGOApply(name, surname, idNumber, cellNumber, age, jobType.ToString());
                personalInfos.Add(newApply);
            }
            return View();
        }

        [HttpGet]
        public ActionResult Donation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Donation(string name, string surname, string idNumber, int cellNumber, int age, int donateAmount)
        {
            PersonalInfo newPerson = null;
            Donation newDonation = (Donation)newPerson;
            newDonation = new Donation(name, surname, idNumber, cellNumber, age, donateAmount);
            personalInfos.Add(newDonation);
            return View();
        }

        [HttpGet]
        public ActionResult Treatment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Treatment(string name, string surname, string idNumber, int cellNumber,int age, int treatmentType)
        {
            PersonalInfo newPerson = null;
            if (treatmentType == 1)
            {
                Treatment newTreatment = (Treatment)newPerson;
                newTreatment = new Treatment(name, surname, idNumber, cellNumber, age, treatmentType.ToString());
                personalInfos.Add(newTreatment);
            }
            if (treatmentType == 2)
            {
                Treatment newTreatment = (Treatment)newPerson;
                newTreatment = new Treatment(name, surname, idNumber, cellNumber, age, treatmentType.ToString());
                personalInfos.Add(newTreatment);
            }
            if (treatmentType == 3)
            {
                Treatment newTreatment = (Treatment)newPerson;
                newTreatment = new Treatment(name, surname, idNumber, cellNumber, age, treatmentType.ToString());
                personalInfos.Add(newTreatment);
            }

            return View();
        }
    }
}