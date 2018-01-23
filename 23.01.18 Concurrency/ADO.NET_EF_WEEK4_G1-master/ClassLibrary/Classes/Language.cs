using ClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Classes
{
    public class Language
    {
        public int Id { get; set; }
        public string LanguageName { get; set; }
        public virtual ICollection<InterpreterLanguageKnowledge> InterpretersToKnow { get; set; }
    }
}
