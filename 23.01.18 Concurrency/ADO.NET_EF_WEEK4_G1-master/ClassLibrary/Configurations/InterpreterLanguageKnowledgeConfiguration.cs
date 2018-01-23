using ClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Configurations
{
    public class InterpreterLanguageKnowledgeConfiguration : EntityTypeConfiguration<InterpreterLanguageKnowledge>
    {
        public InterpreterLanguageKnowledgeConfiguration()
        {
            HasKey(p => new { p.LanguageId, p.InterpreterId });
            Property(p => p.LearnedDate).IsOptional();
            Property(p => p.LevelOfKnowledge).IsRequired();

            HasRequired(p => p.Language)
                .WithMany(p => p.InterpretersToKnow)
                .HasForeignKey(p => p.LanguageId);

            HasRequired(p => p.Interpreter)
                .WithMany(p => p.LanguagesToKnow)
                .HasForeignKey(p => p.InterpreterId);

        }
    }
}
