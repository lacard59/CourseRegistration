using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTTData.Com.Common;

namespace NTTData.Com.BusinessLayer
{
    public static class StudentADO
    {
        public static List<Course> GetAllCourses()
        {
            return new List<Course>();
        }

        public static List<CoursePreference> GetPrefCourses(string studID)
        {
            return new List<CoursePreference>();
        }

        public static int SaveCoursePref(StudentPreference stufPref)
        {
            return 0;
        }
    }
}
