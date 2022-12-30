using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTrainingControl.Infrastructure.Persistence.Migrations
{
    public partial class ExerciseRelationshipAdjusments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Exercises_ExerciseId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Muscles_Exercises_ExerciseId",
                table: "Muscles");

            migrationBuilder.DropIndex(
                name: "IX_Muscles_ExerciseId",
                table: "Muscles");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ExerciseId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ExerciseId",
                table: "Muscles");

            migrationBuilder.DropColumn(
                name: "ExerciseId",
                table: "Categories");

            migrationBuilder.CreateTable(
                name: "CategoryExercise",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    CategoryExercisesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryExercise", x => new { x.CategoriesId, x.CategoryExercisesId });
                    table.ForeignKey(
                        name: "FK_CategoryExercise_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryExercise_Exercises_CategoryExercisesId",
                        column: x => x.CategoryExercisesId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseMuscle",
                columns: table => new
                {
                    MuscleExercisesId = table.Column<int>(type: "int", nullable: false),
                    MusclesWorkedId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseMuscle", x => new { x.MuscleExercisesId, x.MusclesWorkedId });
                    table.ForeignKey(
                        name: "FK_ExerciseMuscle_Exercises_MuscleExercisesId",
                        column: x => x.MuscleExercisesId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseMuscle_Muscles_MusclesWorkedId",
                        column: x => x.MusclesWorkedId,
                        principalTable: "Muscles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryExercise_CategoryExercisesId",
                table: "CategoryExercise",
                column: "CategoryExercisesId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseMuscle_MusclesWorkedId",
                table: "ExerciseMuscle",
                column: "MusclesWorkedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryExercise");

            migrationBuilder.DropTable(
                name: "ExerciseMuscle");

            migrationBuilder.AddColumn<int>(
                name: "ExerciseId",
                table: "Muscles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExerciseId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Muscles_ExerciseId",
                table: "Muscles",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ExerciseId",
                table: "Categories",
                column: "ExerciseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Exercises_ExerciseId",
                table: "Categories",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Muscles_Exercises_ExerciseId",
                table: "Muscles",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id");
        }
    }
}
