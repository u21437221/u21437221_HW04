using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21437221_HW04.Models
{
    public class NGOApply: PersonalInfo
    {
        public string JobType { get; set; }

        public NGOApply(string name, string surname, string idNumber, int cellNumber, int age, string jobType): base(name,surname,idNumber, cellNumber,age)
        {
            JobType = jobType;
        }

        public override string GetSummary()
        {
            return base.GetSummary() + " " + "Job Type:" + JobType;
        }

        public override string endMessage()
        {
            return Name + Surname + "thank you for applying for a job at the NGO: " + JobType;
        }
    }
}