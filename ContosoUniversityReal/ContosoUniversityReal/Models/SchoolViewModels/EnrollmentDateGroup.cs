﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversityReal.Models.SchoolViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}