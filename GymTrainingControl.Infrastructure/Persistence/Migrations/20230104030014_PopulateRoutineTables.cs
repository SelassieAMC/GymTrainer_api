using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTrainingControl.Infrastructure.Persistence.Migrations
{
    public partial class PopulateRoutineTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (1, 1)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (1, 2)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (1, 3)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (1, 4)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (1, 5)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (1, 6)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (1, 7)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (2, 1)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (2, 2)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (2, 3)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (2, 4)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (2, 5)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (2, 6)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (2, 7)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (3, 1)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (3, 2)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (3, 3)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (3, 4)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (3, 5)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (3, 6)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (3, 7)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (4, 1)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (4, 2)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (4, 3)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (4, 4)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (4, 5)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (4, 6)");
            migrationBuilder.Sql("INSERT INTO RoutinePeriodDetails (WeekNumber, DayNumber) VALUES (4, 7)");

            migrationBuilder.Sql(
                "INSERT INTO Routines (PresentationImage, RoutineLevel, Name) VALUES ('https://hips.hearstapps.com/hmg-prod/images/181222-ss19-pb-djprojectrock-s03-0259-15535215622.jpg',0,'Legs by The Rock')");
            migrationBuilder.Sql(
                "INSERT INTO Routines (PresentationImage, RoutineLevel, Name) VALUES ('https://hips.hearstapps.com/hmg-prod/images/181222-ss19-pb-djprojectrock-s05-0254-1575921159.jpg',1,'Arms by The Rock')");
            migrationBuilder.Sql(
                "INSERT INTO Routines (PresentationImage, RoutineLevel, Name) VALUES ('https://hips.hearstapps.com/hmg-prod/images/screen-shot-2021-04-16-at-4-20-22-pm-1618604436.png',3,'Back by The Rock')");
            migrationBuilder.Sql(
                "INSERT INTO Routines (PresentationImage, RoutineLevel, Name) VALUES ('https://hips.hearstapps.com/digitalspyuk.cdnds.net/13/25/dwayne-johnson-the-rock-hercules.jpg',2,'Chest by The Rock')");
            migrationBuilder.Sql(
                "INSERT INTO Routines (PresentationImage, RoutineLevel, Name) VALUES ('https://hips.hearstapps.com/hmg-prod/images/cq5dam-ss20-trn-projrock-dj-shot-2-0449-scrn-v-2-1614961199.jpeg',2,'Shoulder by The Rock')");

            migrationBuilder.Sql(
                "INSERT INTO RoutineExercises (RoutineId, RoutinePeriodDetailId, ExerciseId) VALUES (" +
                "(SELECT Id FROM Routines WHERE Name = 'Legs by The Rock'), " +
                "(SELECT Id FROM RoutinePeriodDetail WHERE WeekNumber = 1 AND DayNumber = 1)," +
                "(SELECT Id FROM Exercises WHERE Name = 'Standing up quad'))");
            
            migrationBuilder.Sql(
                "INSERT INTO RoutineExercises (RoutineId, RoutinePeriodDetailId, ExerciseId) VALUES (" +
                "(SELECT Id FROM Routines WHERE Name = 'Legs by The Rock'), " +
                "(SELECT Id FROM RoutinePeriodDetail WHERE WeekNumber = 1 AND DayNumber = 1)," +
                "(SELECT Id FROM Exercises WHERE Name = 'Step-Up'))");

            migrationBuilder.Sql(
                "INSERT INTO Series (Repetitions, Intensity, Fail, RestInSec, SerieNumber,RoutineExerciseId) " +
                "VALUES (10, 20, 0, 70, 1, " +
                "(SELECT Id FROM RoutineExercise WHERE ExerciseId = (SELECT Id FROM Exercises WHERE Name = 'Step-Up')))");
            
            migrationBuilder.Sql(
                "INSERT INTO Serie (Repetitions, Intensity, Fail, RestInSec, SerieNumber,RoutineExerciseId) " +
                "VALUES (10, 20, 0, 80, 2, " +
                "(SELECT Id FROM RoutineExercise WHERE ExerciseId = (SELECT Id FROM Exercises WHERE Name = 'Step-Up')))");
            
            migrationBuilder.Sql(
                "INSERT INTO Serie (Repetitions, Intensity, Fail, RestInSec, SerieNumber,RoutineExerciseId) " +
                "VALUES (12, 25, 1, 70, 3, " +
                "(SELECT Id FROM RoutineExercise WHERE ExerciseId = (SELECT Id FROM Exercises WHERE Name = 'Step-Up')))");
            
            migrationBuilder.Sql(
                "INSERT INTO Series (Repetitions, Intensity, Fail, RestInSec, SerieNumber,RoutineExerciseId) " +
                "VALUES (8, 10, 0, 50, 1, " +
                "(SELECT Id FROM RoutineExercise WHERE ExerciseId = (SELECT Id FROM Exercises WHERE Name = 'Standing up quad')))");
            
            migrationBuilder.Sql(
                "INSERT INTO Series (Repetitions, Intensity, Fail, RestInSec, SerieNumber,RoutineExerciseId) " +
                "VALUES (10, 15, 0, 60, 2, " +
                "(SELECT Id FROM RoutineExercise WHERE ExerciseId = (SELECT Id FROM Exercises WHERE Name = 'Standing up quad')))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP TABLE RoutinePeriodDetails");
            migrationBuilder.Sql("DROP TABLE Routines");
            migrationBuilder.Sql("DROP TABLE Series");
        }
    }
}
