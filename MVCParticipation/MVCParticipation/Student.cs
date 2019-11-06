using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCParticipation
{
    public class Student
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public int StudentID { get; internal set; }
        public string FavoriteColor { get; internal set; }
    }
}