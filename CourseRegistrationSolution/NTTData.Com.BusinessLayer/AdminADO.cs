using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTTData.Com.Common;

namespace NTTData.Com.BusinessLayer
{
    public static class AdminADO
    {
        public static List<Department> GetAllDept()
        {
            return new List<Department>();
        }

        public static List<Professor> GetAllProf()
        {
            return new List<Professor>();
        }

        public static string SaveCourse(Course c)
        {
            return "test";
        }

        public static string SaveProfessor(Professor p)
        {
            return "test";
        }

        public static string SaveStudent(Student s)
        {
            return "test";
        }
    }
}
