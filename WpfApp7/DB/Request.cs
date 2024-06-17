using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.DB
{
    public class Request
    {
        [Key]
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
