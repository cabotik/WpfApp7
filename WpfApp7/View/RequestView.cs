﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.View
{
    public class RequestView
    {
        public int RequestId { get; set; }
        public string Client { get; set; }
        public string TypeOfMalfunction { get; set; }
        public string Description { get; set; }
        public string Device { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public int DepartmentId { get; set; }
    }
}
