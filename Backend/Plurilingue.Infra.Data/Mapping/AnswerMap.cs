using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plurilingue.Domain.Entities;

namespace Plurilingue.Infra.Data.Mapping
{
    public class AnswerMap : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasOne(a => a.Question).WithMany(q => q.Answers).HasForeignKey(a => a.Question_Id);
            builder.HasOne(a => a.User).WithMany(u => u.Answer).HasForeignKey(a => a.User_Id);
        }
    }
}
