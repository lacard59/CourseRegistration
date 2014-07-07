using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTTData.Com.BusinessLayer;
using NTTData.Com.Common;

namespace NTTData.Com.ServiceLayer
{
    public class CourseService
    {
        public User ValidateUser(string userID, string password)
        {
            return UserADO.ValidateUser(userID, password);
        }

        public string SaveProfessor(Professor p)
        {
            return AdminADO.SaveProfessor(p);
        }

        public string SaveCourse(Course c)
        {
            return AdminADO.SaveCourse(c);
        }

        public string SaveStudent(Student s)
        {
            return AdminADO.SaveStudent(s);
        }

        public List<Professor> GetAllProf()
        {
            return AdminADO.GetAllProf();
        }

        public List<Department> GetAllDept()
        {
            return AdminADO.GetAllDept();
        }
        
        public List<Course> GetAllCourses()
        {
            return StudentADO.GetAllCourses();
        }

        public int savePrefCourses(StudentPreference studPref)
        {
            return StudentADO.SaveCoursePref(studPref);
        }

        public List<CoursePreference> GetPrefCourses(string studID)
        {
            return StudentADO.GetPrefCourses(studID);
        }

    }
}
