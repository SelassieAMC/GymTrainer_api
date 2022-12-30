using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTrainingControl.Infrastructure.Persistence.Migrations
{
    public partial class ManyToManyRelationshipsAdjustments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryExercise_Categories_CategoriesId",
                table: "CategoryExercise");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryExercise_Exercises_ExercisesId",
                table: "CategoryExercise");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseMuscle_Exercises_ExercisesId",
                table: "ExerciseMuscle");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseMuscle_Muscles_MusclesWorkedId",
                table: "ExerciseMuscle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseMuscle",
                table: "ExerciseMuscle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryExercise",
                table: "CategoryExercise");

            migrationBuilder.RenameTable(
                name: "ExerciseMuscle",
                newName: "ExerciseMuscles");

            migrationBuilder.RenameTable(
                name: "CategoryExercise",
                newName: "ExerciseCategories");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseMuscle_MusclesWorkedId",
                table: "ExerciseMuscles",
                newName: "IX_ExerciseMuscles_MusclesWorkedId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryExercise_ExercisesId",
                table: "ExerciseCategories",
                newName: "IX_ExerciseCategories_ExercisesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseMuscles",
                table: "ExerciseMuscles",
                columns: new[] { "ExercisesId", "MusclesWorkedId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseCategories",
                table: "ExerciseCategories",
                columns: new[] { "CategoriesId", "ExercisesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseCategories_Categories_CategoriesId",
                table: "ExerciseCategories",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseCategories_Exercises_ExercisesId",
                table: "ExerciseCategories",
                column: "ExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseMuscles_Exercises_ExercisesId",
                table: "ExerciseMuscles",
                column: "ExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseMuscles_Muscles_MusclesWorkedId",
                table: "ExerciseMuscles",
                column: "MusclesWorkedId",
                principalTable: "Muscles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseCategories_Categories_CategoriesId",
                table: "ExerciseCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseCategories_Exercises_ExercisesId",
                table: "ExerciseCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseMuscles_Exercises_ExercisesId",
                table: "ExerciseMuscles");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseMuscles_Muscles_MusclesWorkedId",
                table: "ExerciseMuscles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseMuscles",
                table: "ExerciseMuscles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseCategories",
                table: "ExerciseCategories");

            migrationBuilder.RenameTable(
                name: "ExerciseMuscles",
                newName: "ExerciseMuscle");

            migrationBuilder.RenameTable(
                name: "ExerciseCategories",
                newName: "CategoryExercise");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseMuscles_MusclesWorkedId",
                table: "ExerciseMuscle",
                newName: "IX_ExerciseMuscle_MusclesWorkedId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseCategories_ExercisesId",
                table: "CategoryExercise",
                newName: "IX_CategoryExercise_ExercisesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseMuscle",
                table: "ExerciseMuscle",
                columns: new[] { "ExercisesId", "MusclesWorkedId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryExercise",
                table: "CategoryExercise",
                columns: new[] { "CategoriesId", "ExercisesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryExercise_Categories_CategoriesId",
                table: "CategoryExercise",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseMuscle_Muscles_MusclesWorkedId",
                table: "ExerciseMuscle",
                column: "MusclesWorkedId",
                principalTable: "Muscles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
