using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReositoryPattern.Models
{
    public class FilterModel
    {
        public string PropertyName { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
    }
}
