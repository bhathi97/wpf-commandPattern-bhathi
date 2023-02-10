using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySheetMenagementSystemForInterns.Classes
{
    class SalaryRecord
    {
        public string TraineeNo { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }

        public string AccountNo { get; set; }
        public string BankName { get; set; }
        public string BankCode { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }

        public int FullWorkDays { get; set; }
        public int HalfWorkDays { get; set;}
        public float TotalWorkDays { get; set; }
        
        public float SalaryAmount { get; set; }

    }
}
