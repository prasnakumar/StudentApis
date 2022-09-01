using Microsoft.EntityFrameworkCore;
using StudentApis.interfaces;
using StudentApis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApis.Service
{
    public class Studentservice : IListStudent
    {
        public readonly DataContext _data;

        public Studentservice(DataContext data)
        {
            _data = data;
        }
        public  async Task<List<StudentDetails>> allStudent()
        {
            var  user= await  _data.student.ToListAsync();
            return user;
            
        }
    }
}
