using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WakeProWebApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LearningPatterns",
                columns: table => new
                {
                    LearningPatternId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningPatterns", x => x.LearningPatternId);
                });

            migrationBuilder.CreateTable(
                name: "PatternTrickMappings",
                columns: table => new
                {
                    MappingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatternId = table.Column<int>(type: "int", nullable: false),
                    TrickId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatternTrickMappings", x => x.MappingId);
                });

            migrationBuilder.CreateTable(
                name: "Tricks",
                columns: table => new
                {
                    TrickId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DifficultyLevel = table.Column<int>(type: "int", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tricks", x => x.TrickId);
                });

            migrationBuilder.CreateTable(
                name: "TrickSubstepMappings",
                columns: table => new
                {
                    MappingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrickId = table.Column<int>(type: "int", nullable: false),
                    SubstepId = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrickSubstepMappings", x => x.MappingId);
                });

            migrationBuilder.CreateTable(
                name: "TrickSubSteps",
                columns: table => new
                {
                    TrickSubStepId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrickSubSteps", x => x.TrickSubStepId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserTrickProgresses",
                columns: table => new
                {
                    UserTrickProgressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TrickId = table.Column<int>(type: "int", nullable: false),
                    TrickSubStepId = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTrickProgresses", x => x.UserTrickProgressId);
                });

            migrationBuilder.InsertData(
                table: "LearningPatterns",
                columns: new[] { "LearningPatternId", "Name" },
                values: new object[,]
                {
                    { 1, "Basic Features" },
                    { 2, "Kicker" },
                    { 3, "Degrees/Spins" }
                });

            migrationBuilder.InsertData(
                table: "PatternTrickMappings",
                columns: new[] { "MappingId", "PatternId", "TrickId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 2 },
                    { 4, 2, 3 },
                    { 5, 2, 4 }
                });

            migrationBuilder.InsertData(
                table: "TrickSubSteps",
                columns: new[] { "TrickSubStepId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "SubStep_1_description", "SubStep_1" },
                    { 2, "SubStep_2_description", "SubStep_2" },
                    { 3, "SubStep_3_description", "SubStep_3" },
                    { 4, "SubStep_4_description", "SubStep_4" },
                    { 5, "SubStep_5_description", "SubStep_5" }
                });

            migrationBuilder.InsertData(
                table: "TrickSubstepMappings",
                columns: new[] { "MappingId", "Order", "SubstepId", "TrickId" },
                values: new object[,]
                {
                    { 1, 0, 1, 1 },
                    { 2, 1, 2, 1 },
                    { 3, 2, 3, 1 },
                    { 4, 3, 4, 1 },
                    { 5, 4, 5, 1 },
                    { 6, 0, 1, 2 },
                    { 7, 1, 2, 2 },
                    { 8, 2, 3, 2 },
                    { 9, 3, 4, 2 },
                    { 10, 4, 5, 3 },
                    { 11, 0, 1, 3 },
                    { 12, 1, 2, 3 },
                    { 13, 2, 3, 3 },
                    { 14, 3, 4, 3 },
                    { 15, 4, 5, 3 }
                });

            migrationBuilder.InsertData(
                table: "Tricks",
                columns: new[] { "TrickId", "Description", "DifficultyLevel", "Name", "VideoUrl" },
                values: new object[,]
                {
                    { 1, "Trick 1 description", 1, "Trick1", "https://www.example.com/trick1" },
                    { 2, "Trick 2 description", 1, "Trick2", "https://www.example.com/trick2" },
                    { 3, "Trick 3 description", 2, "Trick3", "https://www.example.com/trick3" },
                    { 4, "Trick 4 description", 2, "Trick4", "https://www.example.com/trick4" },
                    { 5, "Trick 5 description", 3, "Trick5", "https://www.example.com/trick5" }
                });

            migrationBuilder.InsertData(
                table: "UserTrickProgresses",
                columns: new[] { "UserTrickProgressId", "IsCompleted", "TrickId", "TrickSubStepId", "UserId" },
                values: new object[,]
                {
                    { 1, true, 1, 1, 1 },
                    { 2, false, 2, 2, 2 },
                    { 3, false, 3, 3, 3 },
                    { 4, false, 4, 4, 4 },
                    { 5, false, 5, 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, "user1@example.com", "Password1", "user1" },
                    { 2, "user2@example.com", "Password2", "user2" },
                    { 3, "user3@example.com", "Password3", "user3" },
                    { 4, "user4@example.com", "Password4", "user4" },
                    { 5, "user5@example.com", "Password5", "user5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LearningPatterns");

            migrationBuilder.DropTable(
                name: "PatternTrickMappings");

            migrationBuilder.DropTable(
                name: "Tricks");

            migrationBuilder.DropTable(
                name: "TrickSubstepMappings");

            migrationBuilder.DropTable(
                name: "TrickSubSteps");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTrickProgresses");
        }
    }
}
