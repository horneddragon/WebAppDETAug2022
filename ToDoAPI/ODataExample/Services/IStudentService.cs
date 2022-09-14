using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ODataExample.Models;


namespace ODataExample.Services
{
    public interface IStudentService
    {
        IQueryable<Student> RetrieveAllStudents();
    }
}