using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Classes
{
    public class Husband
    {
        public int HusbandId { get; set; }
        public string HusbandName { get; set; }
        public virtual Wife Wife { get; set; }
    }
}
