using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTrainingControl.Infrastructure.Persistence.Migrations
{
    public partial class PopulateInitialExercises : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Add Exercises
            migrationBuilder.Sql(
                "INSERT INTO Exercises (name, description, image) " +
                "values (" +
                "'Standing up quad', " +
                "'Stretching the quadriceps muscles improves flexibility for this large muscle found in the front of thigh." +
                " This stretch is a common one used as part of a warmup or after-exercise stretching, especially for activities" +
                " such as cycling, running, and yoga. There are many different ways to stretch your quadriceps, but this " +
                "is a simple version you can do while standing.'," +
                "'https://www.aleanlife.com/wp-content/uploads/2021/03/standing-quad-stretch-366x490.jpg'" +
                ")");
            
            migrationBuilder.Sql(
                "INSERT INTO Exercises (name, description, image) " +
                "values (" +
                "'Step-Up', " +
                "'With all of the attention paid to the squat, the step-up often gets overlooked. Indeed, many people " +
                "simply consider the step-up an “alternative” to that king of lower body exercises — something you do " +
                "only when when you need to switch things up.'," +
                "'https://bod-blog-assets.prod.cd.beachbodyondemand.com/bod-blog/wp-content/uploads/2016/07/27114723/step-up-600-demo.jpg'" +
                ")");
            
            // Add Categories
            migrationBuilder.Sql("INSERT INTO Categories (name, description) values ('Legs', 'Exercise for legs')");
            migrationBuilder.Sql("INSERT INTO Categories (name, description) values ('Chest', 'Exercise for Chest')");
            migrationBuilder.Sql("INSERT INTO Categories (name, description) values ('Back', 'Exercise for Back')");
            migrationBuilder.Sql("INSERT INTO Categories (name, description) values ('Arms', 'Exercise for Arms')");
            migrationBuilder.Sql("INSERT INTO Categories (name, description) values ('Pull', 'Pull Exercises')");
            migrationBuilder.Sql("INSERT INTO Categories (name, description) values ('Push', 'Push Exercises')");
            migrationBuilder.Sql("INSERT INTO Categories (name, description) values ('Aerobic', 'Aerobic Exercises')");
            migrationBuilder.Sql("INSERT INTO Categories (name, description) values ('Bodyweight', 'Exercises with your own body weight.')");
            
            // Add Muscles
            migrationBuilder.Sql("INSERT INTO Muscles (name, image) values ('Cuadriceps', 'https://www.escuelaculturismonatural.com/wp-content/uploads/elementor/thumbs/Quadriceps-muscles-e1660481667161-pt94479g84lgtxwid7byvpxbpswzq758ltel76ee9k.png')");
            migrationBuilder.Sql("INSERT INTO Muscles (name, image) values ('Biceps', 'https://barbend.com/es/wp-content/uploads/sites/2/2020/06/image6-1.jpg')");
            migrationBuilder.Sql("INSERT INTO Muscles (name, image) values ('Triceps', 'https://images.hola.com/imagenes/estar-bien/20210311185849/ejercicios-triceps-fortalecer-brazos/0-929-371/ejercicios-triceps5-a.jpg')");
            migrationBuilder.Sql("INSERT INTO Muscles (name, image) values ('Glutes', 'http://cdn.shopify.com/s/files/1/0870/1170/files/gluteus-muscle._1024x1024.jpg')");
            
            // Add ExerciseCategories relationships
            migrationBuilder.Sql("INSERT INTO CategoryExercise values (" +
                                 "(SELECT Id FROM Categories WHERE name = 'Legs')," +
                                 "(SELECT Id FROM Exercises WHERE name = 'Standing up quad'))");
            
            migrationBuilder.Sql("INSERT INTO CategoryExercise values (" +
                                 "(SELECT Id FROM Categories WHERE name = 'Bodyweight')," +
                                 "(SELECT Id FROM Exercises WHERE name = 'Standing up quad'))");
            
            migrationBuilder.Sql("INSERT INTO CategoryExercise values (" +
                                 "(SELECT Id FROM Categories WHERE name = 'Legs')," +
                                 "(SELECT Id FROM Exercises WHERE name = 'Step-Up'))");
            
            migrationBuilder.Sql("INSERT INTO CategoryExercise values (" +
                                 "(SELECT Id FROM Categories WHERE name = 'Push')," +
                                 "(SELECT Id FROM Exercises WHERE name = 'Step-Up'))");
            
            // Add ExerciseMuscles relationships
            migrationBuilder.Sql("INSERT INTO ExerciseMuscle values (" +
                                 "(SELECT Id FROM Exercises WHERE name = 'Step-Up')," +
                                 "(SELECT Id FROM Muscles WHERE name = 'Cuadriceps'))");
            
            migrationBuilder.Sql("INSERT INTO ExerciseMuscle values (" +
                                 "(SELECT Id FROM Exercises WHERE name = 'Standing up quad')," +
                                 "(SELECT Id FROM Muscles WHERE name = 'Cuadriceps'))");
            
            migrationBuilder.Sql("INSERT INTO ExerciseMuscle values (" +
                                 "(SELECT Id FROM Exercises WHERE name = 'Step-Up')," +
                                 "(SELECT Id FROM Muscles WHERE name = 'Glutes'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE TABLE ExerciseMuscle");
            migrationBuilder.Sql("TRUNCATE TABLE CategoryExercise");
            migrationBuilder.Sql("TRUNCATE TABLE Exercises");
            migrationBuilder.Sql("TRUNCATE TABLE Categories");
            migrationBuilder.Sql("TRUNCATE TABLE Muscles");
        }
    }
}
