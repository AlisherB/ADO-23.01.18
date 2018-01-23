using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Classes
{
    public class Wife
    {
        public int WifeId { get; set; }
        public string WifeName { get; set; }
        public virtual Husband Husband { get; set; }
    }
}
