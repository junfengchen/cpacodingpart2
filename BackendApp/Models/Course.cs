using System;
using System.Collections.Generic;

namespace BackendApp.Models
{
    public class Result
    {
        public static readonly string FAIL = "FAIL";
        public static readonly string PASS = "PASS";
        public int year { get; set; }
        public string grade { get; set; }
    }

    public class Course
    {
        public string subject { get; set; }

        public Result[] results { get; set; }
    }
}
