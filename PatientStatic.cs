﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Test
{
    public static class PatientStatic
    {
        public static string FirstName { get; set; }
        public static string LastName { get; set; }

        public static string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}

