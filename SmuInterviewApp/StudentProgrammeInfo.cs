using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuInterviewApp
{
    public class StudentProgrammeInfo
    {
        [Key]
        [Required]
        public string StudentID { get; set; }

        public string ProgrammeID { get; set; }


        public string Status { get; set; }

        public DateTime LastUpdateDateTime { get; set; }

    }

  
}
