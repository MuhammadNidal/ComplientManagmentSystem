﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplientManagmentSystem.Domain.Entities
{
    public class Complaint
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateFiled { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }  // Assuming a User entity exists
    }
}
