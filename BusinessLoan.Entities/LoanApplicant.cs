using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLoan.Entities
{
    class LoanApplicant
    {
        public int LoanId { get; set; }
        public string LoanType { get; set; }
        public string LoanAmountRequired { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantAddress { get; set; }
        public string ApplicantMobile { get; set; }
        public string ApplicantEmail { get; set; }
        public string ApplicantAadhar { get; set; }
        public string ApplicantPan { get; set; }
        public string ApplicantSalary { get; set; }
        public string LoanRepaymentMethod { get; set; }
        public string LoanRepaymentMonths { get; set; }
        public string TimestampOfLoan { get; set; }
        public int DocumentID { get; set; }
    }
}
