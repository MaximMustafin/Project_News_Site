﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maganizer_Project.DAL.Entities
{
    public class UserProfile
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public byte[] Avatar { get; set; }
        public string About { get; set; }
        public string PhoneNumber { get; set; }
        public string WebSiteUrl { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
