using ConsoleApp11.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Classes
{
    public class InterpreterLanguageKnowledge
    {
        public int InterpreterId { get; set; }
        public int LanguageId { get; set; }
        public virtual Interpreter Interpreter { get; set; }
        public virtual Language Language { get; set; }
        public DateTime? LearnedDate { get; set; }
        public string LevelOfKnowledge { get; set; }
    }
}
