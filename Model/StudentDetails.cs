using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApis.Model
{
    public class StudentDetails
    {
        [Key]
        public  int Id { get; set; }
        
        [Required]
        public  string StudentName { get; set; }

       public string RollNumber { get; set; }

        public int StudentClass { get; set; }

        public string section { get; set; }

      // public int year_of_enrollment { get; set; }


    }
}
