using Microsoft.EntityFrameworkCore.Migrations;

namespace Questionnaire.Migrations {
    public partial class ChangeLastName : Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.RenameColumn("LasteName", "Questions", "LastName");
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.RenameColumn("LastName", "Questions", "LasteName");
        }
    }
}
