using StudentApis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApis.interfaces
{
    public interface IListStudent
    {
        public  Task<List<StudentDetails>> allStudent();
    }
}
