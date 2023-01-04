using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTrainingControl.Infrastructure.Persistence.Migrations
{
    public partial class PluralTableNaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoutineExercise_Exercises_ExerciseId",
                table: "RoutineExercise");

            migrationBuilder.DropForeignKey(
                name: "FK_RoutineExercise_RoutinePeriodDetail_RoutinePeriodDetailId",
                table: "RoutineExercise");

            migrationBuilder.DropForeignKey(
                name: "FK_RoutineExercise_Routines_RoutineId",
                table: "RoutineExercise");

            migrationBuilder.DropForeignKey(
                name: "FK_Serie_RoutineExercise_RoutineExerciseId",
                table: "Serie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Serie",
                table: "Serie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoutinePeriodDetail",
                table: "RoutinePeriodDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoutineExercise",
                table: "RoutineExercise");

            migrationBuilder.RenameTable(
                name: "Serie",
                newName: "Series");

            migrationBuilder.RenameTable(
                name: "RoutinePeriodDetail",
                newName: "RoutinePeriodDetails");

            migrationBuilder.RenameTable(
                name: "RoutineExercise",
                newName: "RoutineExercises");

            migrationBuilder.RenameIndex(
                name: "IX_Serie_RoutineExerciseId",
                table: "Series",
                newName: "IX_Series_RoutineExerciseId");

            migrationBuilder.RenameIndex(
                name: "IX_RoutineExercise_RoutinePeriodDetailId",
                table: "RoutineExercises",
                newName: "IX_RoutineExercises_RoutinePeriodDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_RoutineExercise_RoutineId",
                table: "RoutineExercises",
                newName: "IX_RoutineExercises_RoutineId");

            migrationBuilder.RenameIndex(
                name: "IX_RoutineExercise_ExerciseId",
                table: "RoutineExercises",
                newName: "IX_RoutineExercises_ExerciseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Series",
                table: "Series",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoutinePeriodDetails",
                table: "RoutinePeriodDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoutineExercises",
                table: "RoutineExercises",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoutineExercises_Exercises_ExerciseId",
                table: "RoutineExercises",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoutineExercises_RoutinePeriodDetails_RoutinePeriodDetailId",
                table: "RoutineExercises",
                column: "RoutinePeriodDetailId",
                principalTable: "RoutinePeriodDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoutineExercises_Routines_RoutineId",
                table: "RoutineExercises",
                column: "RoutineId",
                principalTable: "Routines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Series_RoutineExercises_RoutineExerciseId",
                table: "Series",
                column: "RoutineExerciseId",
                principalTable: "RoutineExercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoutineExercises_Exercises_ExerciseId",
                table: "RoutineExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_RoutineExercises_RoutinePeriodDetails_RoutinePeriodDetailId",
                table: "RoutineExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_RoutineExercises_Routines_RoutineId",
                table: "RoutineExercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_RoutineExercises_RoutineExerciseId",
                table: "Series");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Series",
                table: "Series");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoutinePeriodDetails",
                table: "RoutinePeriodDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoutineExercises",
                table: "RoutineExercises");

            migrationBuilder.RenameTable(
                name: "Series",
                newName: "Serie");

            migrationBuilder.RenameTable(
                name: "RoutinePeriodDetails",
                newName: "RoutinePeriodDetail");

            migrationBuilder.RenameTable(
                name: "RoutineExercises",
                newName: "RoutineExercise");

            migrationBuilder.RenameIndex(
                name: "IX_Series_RoutineExerciseId",
                table: "Serie",
                newName: "IX_Serie_RoutineExerciseId");

            migrationBuilder.RenameIndex(
                name: "IX_RoutineExercises_RoutinePeriodDetailId",
                table: "RoutineExercise",
                newName: "IX_RoutineExercise_RoutinePeriodDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_RoutineExercises_RoutineId",
                table: "RoutineExercise",
                newName: "IX_RoutineExercise_RoutineId");

            migrationBuilder.RenameIndex(
                name: "IX_RoutineExercises_ExerciseId",
                table: "RoutineExercise",
                newName: "IX_RoutineExercise_ExerciseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Serie",
                table: "Serie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoutinePeriodDetail",
                table: "RoutinePeriodDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoutineExercise",
                table: "RoutineExercise",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoutineExercise_Exercises_ExerciseId",
                table: "RoutineExercise",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoutineExercise_RoutinePeriodDetail_RoutinePeriodDetailId",
                table: "RoutineExercise",
                column: "RoutinePeriodDetailId",
                principalTable: "RoutinePeriodDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoutineExercise_Routines_RoutineId",
                table: "RoutineExercise",
                column: "RoutineId",
                principalTable: "Routines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Serie_RoutineExercise_RoutineExerciseId",
                table: "Serie",
                column: "RoutineExerciseId",
                principalTable: "RoutineExercise",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
