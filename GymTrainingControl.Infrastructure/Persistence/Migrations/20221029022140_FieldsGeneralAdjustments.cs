using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTrainingControl.Infrastructure.Persistence.Migrations
{
    public partial class FieldsGeneralAdjustments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryExercise_Exercises_CategoryExercisesId",
                table: "CategoryExercise");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseMuscle_Exercises_MuscleExercisesId",
                table: "ExerciseMuscle");

            migrationBuilder.RenameColumn(
                name: "MuscleExercisesId",
                table: "ExerciseMuscle",
                newName: "ExercisesId");

            migrationBuilder.RenameColumn(
                name: "CategoryExercisesId",
                table: "CategoryExercise",
                newName: "ExercisesId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryExercise_CategoryExercisesId",
                table: "CategoryExercise",
                newName: "IX_CategoryExercise_ExercisesId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Muscles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryExercise_Exercises_ExercisesId",
                table: "CategoryExercise",
                column: "ExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseMuscle_Exercises_ExercisesId",
                table: "ExerciseMuscle",
                column: "ExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryExercise_Exercises_ExercisesId",
                table: "CategoryExercise");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseMuscle_Exercises_ExercisesId",
                table: "ExerciseMuscle");

            migrationBuilder.RenameColumn(
                name: "ExercisesId",
                table: "ExerciseMuscle",
                newName: "MuscleExercisesId");

            migrationBuilder.RenameColumn(
                name: "ExercisesId",
                table: "CategoryExercise",
                newName: "CategoryExercisesId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryExercise_ExercisesId",
                table: "CategoryExercise",
                newName: "IX_CategoryExercise_CategoryExercisesId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Muscles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryExercise_Exercises_CategoryExercisesId",
                table: "CategoryExercise",
                column: "CategoryExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseMuscle_Exercises_MuscleExercisesId",
                table: "ExerciseMuscle",
                column: "MuscleExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
