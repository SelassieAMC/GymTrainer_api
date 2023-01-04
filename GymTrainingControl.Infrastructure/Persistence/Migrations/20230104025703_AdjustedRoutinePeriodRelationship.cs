using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTrainingControl.Infrastructure.Persistence.Migrations
{
    public partial class AdjustedRoutinePeriodRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoutineExercise_Exercises_ExercisesId",
                table: "RoutineExercise");

            migrationBuilder.DropForeignKey(
                name: "FK_RoutineExercise_Routines_RoutinesId",
                table: "RoutineExercise");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoutineExercise",
                table: "RoutineExercise");

            migrationBuilder.RenameColumn(
                name: "RoutinesId",
                table: "RoutineExercise",
                newName: "RoutinePeriodDetailId");

            migrationBuilder.RenameColumn(
                name: "ExercisesId",
                table: "RoutineExercise",
                newName: "RoutineId");

            migrationBuilder.RenameIndex(
                name: "IX_RoutineExercise_RoutinesId",
                table: "RoutineExercise",
                newName: "IX_RoutineExercise_RoutinePeriodDetailId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "RoutineExercise",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ExerciseId",
                table: "RoutineExercise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IntensityMeasure",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TimeExpendInSec",
                table: "Exercises",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoutineExercise",
                table: "RoutineExercise",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RoutinePeriodDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeekNumber = table.Column<int>(type: "int", nullable: false),
                    DayNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoutinePeriodDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Serie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Repetitions = table.Column<int>(type: "int", nullable: false),
                    Intensity = table.Column<int>(type: "int", nullable: false),
                    Fail = table.Column<bool>(type: "bit", nullable: false),
                    RestInSec = table.Column<int>(type: "int", nullable: false),
                    SerieNumber = table.Column<int>(type: "int", nullable: false),
                    RoutineExerciseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Serie_RoutineExercise_RoutineExerciseId",
                        column: x => x.RoutineExerciseId,
                        principalTable: "RoutineExercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoutineExercise_ExerciseId",
                table: "RoutineExercise",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_RoutineExercise_RoutineId",
                table: "RoutineExercise",
                column: "RoutineId");

            migrationBuilder.CreateIndex(
                name: "IX_Serie_RoutineExerciseId",
                table: "Serie",
                column: "RoutineExerciseId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "RoutinePeriodDetail");

            migrationBuilder.DropTable(
                name: "Serie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoutineExercise",
                table: "RoutineExercise");

            migrationBuilder.DropIndex(
                name: "IX_RoutineExercise_ExerciseId",
                table: "RoutineExercise");

            migrationBuilder.DropIndex(
                name: "IX_RoutineExercise_RoutineId",
                table: "RoutineExercise");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RoutineExercise");

            migrationBuilder.DropColumn(
                name: "ExerciseId",
                table: "RoutineExercise");

            migrationBuilder.DropColumn(
                name: "IntensityMeasure",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "TimeExpendInSec",
                table: "Exercises");

            migrationBuilder.RenameColumn(
                name: "RoutinePeriodDetailId",
                table: "RoutineExercise",
                newName: "RoutinesId");

            migrationBuilder.RenameColumn(
                name: "RoutineId",
                table: "RoutineExercise",
                newName: "ExercisesId");

            migrationBuilder.RenameIndex(
                name: "IX_RoutineExercise_RoutinePeriodDetailId",
                table: "RoutineExercise",
                newName: "IX_RoutineExercise_RoutinesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoutineExercise",
                table: "RoutineExercise",
                columns: new[] { "ExercisesId", "RoutinesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_RoutineExercise_Exercises_ExercisesId",
                table: "RoutineExercise",
                column: "ExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoutineExercise_Routines_RoutinesId",
                table: "RoutineExercise",
                column: "RoutinesId",
                principalTable: "Routines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
