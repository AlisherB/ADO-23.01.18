using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Classes
{
    public class Computer
    {
        public int Id { get; set; }
        public Monitor Monitor { get; set; }
        public SystemBlock SystemBlock { get; set; }
        public Computer()
        {
            Monitor = new Monitor();
            SystemBlock = new SystemBlock();
        }
    }
}
