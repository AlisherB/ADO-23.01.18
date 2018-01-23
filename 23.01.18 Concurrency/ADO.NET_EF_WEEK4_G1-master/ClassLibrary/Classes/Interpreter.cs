using ClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Classes
{
    public class Interpreter
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public virtual ICollection<InterpreterLanguageKnowledge> LanguagesToKnow { get; set; }
    }
}
