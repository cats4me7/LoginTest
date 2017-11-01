﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginTest5.Models
{
    public class PassRegistration
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public int NumberInHouse { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}