﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Lecturer : Person
    {
        IEnumerable<LecturerCourse> listOfCourses;
        public override string ToString() => this.ToStringProperty();
    }
}
