﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Care_System.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string? Name { get; set; }
        public string? Specialization { get; set; }

        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
