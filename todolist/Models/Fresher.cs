using System;
using System.Collections.Generic;

namespace todolist.Models
{
    public partial class Fresher
    {
        public Guid FresherId { get; set; }
        public string FresherCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
    }
}
