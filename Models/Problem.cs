using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudyWebApp.Models
{
    public class Problem
    {
        public int Id { get; set; }
        [Display(Name = "Practice problem:")]
        [Required(ErrorMessage = "Practice problem field may not be left empty")]
        public string ProblemQuestion { get; set; }
        [Display(Name = "Problem Solution:")]
        [Required(ErrorMessage = "Problem solution field may not be left empty")]
        public string ProblemAnswer { get; set; }
        [Display(Name = "Username of problem submitter:")]
        public string UsersName { get; set; }

        public Problem()
        {
        }

    }
}
