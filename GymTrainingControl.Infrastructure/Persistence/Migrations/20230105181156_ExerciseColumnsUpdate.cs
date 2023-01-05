using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTrainingControl.Infrastructure.Persistence.Migrations
{
    public partial class ExerciseColumnsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeExpendInSec",
                table: "Exercises",
                newName: "TimeSpentInSec");

            migrationBuilder.AlterColumn<float>(
                name: "Calories",
                table: "Exercises",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeSpentInSec",
                table: "Exercises",
                newName: "TimeExpendInSec");

            migrationBuilder.AlterColumn<int>(
                name: "Calories",
                table: "Exercises",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
