using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySheetMenagementSystemForInterns.Classes
{
    class Trainee
    {
        public string TraineeNo { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public string Location { get; set; }
        public string ShouldPay { get; set; }
        public string TelephoneNo { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string Months { get; set; }
        public float SalaryPerDay { get; set; }

        public Trainee() { }
    }
}
