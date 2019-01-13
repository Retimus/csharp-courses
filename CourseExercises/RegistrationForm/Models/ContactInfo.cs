﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Helpers;

namespace WindowsFormsApp1.Models
{
    public class ContactInfo
    {
        public string Email { get; set; }
        public string Phone { get; set; }

        public bool IsValid()
        {
            return Validator.ValidateEmail(Email) &&
                   Validator.ValidateNumber(Phone);
        }
    }
}
