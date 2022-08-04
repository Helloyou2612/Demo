using System;
using System.Collections.Generic;

namespace DemoFilePicker
{
    public class DataModel
    {
        public List<User> Users { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AuthType { get; set; }
        public string Salt { get; set; }
        public string PassHash { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public object UpdatedDate { get; set; }
        public object UpdatedBy { get; set; }
    }
}