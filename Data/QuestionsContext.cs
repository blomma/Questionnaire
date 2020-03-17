using Microsoft.EntityFrameworkCore;

namespace Data {
    public class QuestionsContext : DbContext {
        public QuestionsContext(
            DbContextOptions<QuestionsContext> options)
            : base(options) {
        }

        public DbSet<Models.Questions> Questions { get; set; }
    }

}