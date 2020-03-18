using Microsoft.EntityFrameworkCore;

namespace Data {
    public class QuestionnaireContext : DbContext {
        public QuestionnaireContext(
            DbContextOptions<QuestionnaireContext> options)
            : base(options) {
        }

        public DbSet<Models.Questionnaire.WhatsMyName> WhatsMyName { get; set; }
    }
}