using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTrainingControl.Infrastructure.Persistence.Migrations
{
    public partial class PopulateExercisesAndUpdateOldRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE Exercises SET " +
                     "PresentationImage = 'https://images.squarespace-cdn.com/content/v1/5d31ed671abe780001b2964d/1620246551381-QEZGA2YV5CCQITMAV21U/A+woman+doing+a+standing+quad+stretch', " +
                     "Video = 'https://www.youtube.com/watch?v=f1zuIa3TQzc', " +
                     "IntensityMeasure = 'Sec', " +
                     "TimeSpentInSec=30, Calories='0.12'," +
                     "Image ='https://thumbs.gfycat.com/DeliriousFearfulIslandcanary-max-1mb.gif' " +
                     "WHERE Name = 'Standing up quad'");
            
            migrationBuilder.Sql("UPDATE Exercises SET " +
                     "PresentationImage = 'https://cdn.shortpixel.ai/spai/q_glossy+w_1003+to_auto+ret_img/https://www.healthconstitution.com.au/wp-content/uploads/2022/02/Proper-Step-Up-Exercise-Form.jpg', " +
                     "Video = 'https://www.youtube.com/watch?v=wfhXnLILqdk', " +
                     "IntensityMeasure = 'NotApply', " +
                     "TimeSpentInSec= 4, Calories='3.8'," +
                     "Image ='https://hips.hearstapps.com/hmg-prod/images/workouts/2016/03/stepup-1457044957.gif' " +
                     "WHERE Name = 'Step-Up'");

            migrationBuilder.Sql(
                "INSERT INTO Exercises (Image, Name, Description, Calories, PresentationImage, Video, IntensityMeasure, TimeSpentInSec) " +
                "VALUES ('https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/pushup-gif-1544694650.gif'," +
                "'Press-Up'," +
                "'This move uses multiple muscle groups for maximum growth and strengthens your shoulder joints. Easily done as an exercise at home, this prepares you for progression to the more demanding shoulder exercises you`ll face in a gym, like the incline bench press.'," +
                "0.31," +
                "'https://madbarzpictures.blob.core.windows.net/madbarzpictures/top-5-push-up-benefits.jpg'," +
                "'https://www.youtube.com/watch?v=_l3ySVKYVJ8'," +
                "'NotApply',3)");
            
            migrationBuilder.Sql(
                "INSERT INTO Exercises (Image, Name, Description, Calories, PresentationImage, Video, IntensityMeasure, TimeSpentInSec) " +
                "VALUES ('https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/dumbbell-press.gif'," +
                "'Dumbbell standing shoulder press'," +
                "'This is a safer shoulder-sculptor than lifting from behind your neck. As a beginner the aim should be to keep strain off your joints and protect against an injury called shoulder impingement syndrome. Missed sessions this early in your lifting career are especially costly.'," +
                "0.18," +
                "'https://www.kingofthegym.com/wp-content/uploads/2012/11/dumbbell-shoulder-press-benefits.jpg'," +
                "'https://www.youtube.com/watch?v=e_f5oodNEcI'," +
                "'Kg',3)");
            
            migrationBuilder.Sql(
                "INSERT INTO Exercises (Image, Name, Description, Calories, PresentationImage, Video, IntensityMeasure, TimeSpentInSec) " +
                "VALUES ('https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/skip.gif'," +
                "'Skipping'," +
                "'The ultimate no-nonsense workout, jumping rope could be the most efficient form of cardio. A study that found just 10 minutes a day with the rope was similar to 30 minutes of jogging.'," +
                "0.25," +
                "'https://hips.hearstapps.com/hmg-prod/images/701/jump-roping-total-body-workout-0-1516282424.jpg'," +
                "'https://www.youtube.com/watch?v=J6W3V75tQtE'," +
                "'Sec',1)");
            
            migrationBuilder.Sql(
                "INSERT INTO Exercises (Image, Name, Description, Calories, PresentationImage, Video, IntensityMeasure, TimeSpentInSec) " +
                "VALUES ('https://hips.hearstapps.com/hmg-prod/images/workouts/2016/03/barbelldeadlift-1457038089.gif'," +
                "'Deadlift'," +
                "'The king of compound exercises, it`s hard to beat the deadlift for a strength-building, muscle-gaining move. Still, a lot of men shy away from the exercise, for fear of poor form, complicated manoeuvring and getting injured.'," +
                "1," +
                "'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/deadlift-workout-for-back-royalty-free-image-527680187-1553003041.jpg'," +
                "'https://www.youtube.com/watch?v=op9kVnSso6Q'," +
                "'Kg'," +
                "3)");
            
            migrationBuilder.Sql(
                "INSERT INTO Exercises (Image, Name, Description, Calories, PresentationImage, Video, IntensityMeasure, TimeSpentInSec) " +
                "VALUES ('https://hips.hearstapps.com/hmg-prod/images/workouts/2017/10/legpress-1509458589.gif'," +
                "'Leg Press'," +
                "'In the leg press machine position your feet shoulder-width apart on the platform and raise until your legs are outstretched without locking your knees. Slowly lower the platform until your knees are at 90 degrees to the floor, then push back to the start position through your heels.'," +
                "0.15," +
                "'https://blogscdn.thehut.net/app/uploads/sites/450/2021/05/shutterstock_710376784opt_hero_1620635665_1620897738.jpg'," +
                "'https://www.youtube.com/watch?v=s9-zeWzPUmA'," +
                "'Kg'," +
                "3)");
            
            migrationBuilder.Sql(
                "INSERT INTO Exercises (Image, Name, Description, Calories, PresentationImage, Video, IntensityMeasure, TimeSpentInSec) " +
                "VALUES ('https://homeworkouts.org/wp-content/uploads/anim-kettlebell-pistol-squats.gif'," +
                "'Kettlebell Pistol Squats'," +
                "'Squats are an extremely functional exercise as they teach us to maintain a neutral spine while bending down to pick things up from the legs instead of the back. The pistol squat is a unilateral version that really challenges your ankle and knee stability, as well.'," +
                "'0.19'," +
                "'https://madbarzpictures.blob.core.windows.net/madbarzpictures/imagefff9a29a-a4b4-4981-9d4f-6cb9d02b8730.png'," +
                "'https://www.youtube.com/watch?v=-U-TwEl411U'," +
                "'Kg'," +
                "'3')");
            
            migrationBuilder.Sql(
                "INSERT INTO Exercises (Image, Name, Description, Calories, PresentationImage, Video, IntensityMeasure, TimeSpentInSec) " +
                "VALUES ('https://experiencelife.lifetime.life/wp-content/uploads/2021/07/bid-side-plank.jpg'," +
                "'Side Plank'," +
                "'Lie on your left side with your knees straight and prop your upper body up to take its weight on your forearm. Brace your core and raise your hips until your body forms a straight line. Hold this position while breathing deeply. Then roll over and repeat on the other side.'," +
                "0.115," +
                "'https://www.muscleandfitness.com/wp-content/uploads/2018/09/1109-side-plank-1.jpg'," +
                "'https://www.youtube.com/watch?v=_R389Jk0tIo'," +
                "'Sec'," +
                "1)");
            
            migrationBuilder.Sql(
                "INSERT INTO Exercises (Image, Name, Description, Calories, PresentationImage, Video, IntensityMeasure, TimeSpentInSec) " +
                "VALUES ('https://hips.hearstapps.com/hmg-prod/images/workouts/2016/08/crunchreversecrunchppt-1472137016.gif'," +
                "'Reverse Crunch'," +
                "'Lie facup on a bench with your knees and hips bent 90 degrees. Grab the sides of the bench behind your head for support. This is the starting position.'," +
                "0.25," +
                "'https://cdn.shopify.com/s/files/1/1876/4703/articles/shutterstock_120709828_2859x.jpg'," +
                "'https://www.youtube.com/watch?v=aIyadD7d7OA'," +
                "'Sec'," +
                "3)");
            
            migrationBuilder.Sql(
                "INSERT INTO Exercises (Image, Name, Description, Calories, PresentationImage, Video, IntensityMeasure, TimeSpentInSec) " +
                "VALUES ('https://www.gymguider.com/wp-content/uploads/2017/10/medicine-ball-v-up.gif'," +
                "'Medicine Ball Jackknife'," +
                "'Holding a medicine ball with both hands, lie flat on your back with legs straight and arms extended past your head. Tighten abs and bring your legs and arms up to form a V. Try to touch the ball with your feet. Hold for one count and return to starting position.'," +
                "0.35," +
                "'https://s3.amazonaws.com/prod.skimble/assets/1863780/skimble-workout-trainer-exercise-medicine-ball-jackknife-3_iphone.jpg'," +
                "'https://www.youtube.com/watch?v=EqrDreTMJ3g'," +
                "'NotApply'," +
                "3)");
            
            migrationBuilder.Sql(
                "INSERT INTO Exercises (Image, Name, Description, Calories, PresentationImage, Video, IntensityMeasure, TimeSpentInSec) " +
                "VALUES ('https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/meadows-row.gif'," +
                "'Single-arm T-Bar Rows'," +
                "'You’ve probably seen the standard T-bar row being performed (often incorrectly) at the gym, but the single-arm T-bar row ensures that, as you’re using a lighter load, form is stricter and muscle imbalances are being ironed out.'," +
                "0.33," +
                "'https://samsfitness.com.au/image/cache/catalog/atx-tbr-sig-h28/one-arm-row-exercise-800x800.jpg'," +
                "'https://www.youtube.com/watch?v=Biu_akIOyHc'," +
                "'Kg'," +
                "3)");
            
            migrationBuilder.Sql(
                "INSERT INTO Exercises (Image, Name, Description, Calories, PresentationImage, Video, IntensityMeasure, TimeSpentInSec) " +
                "VALUES ('https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/invertedrow.gif?resize=768:*'," +
                "'Inverted Row'," +
                "'Suitable for those struggling with pull-ups and chin-ups, the inverted row is surprisingly difficult. Smoking your back and your arms, you can progress or regress the move by re-arranging where your feet.'," +
                "0.31," +
                "'https://cdn.mos.cms.futurecdn.net/63Y9gtJj7viPyzj7hTJvsN.jpg'," +
                "'https://www.youtube.com/watch?v=9fItzuh9Iok'," +
                "'NotApply'," +
                "3)");
            
            migrationBuilder.Sql(
                "INSERT INTO Exercises (Image, Name, Description, Calories, PresentationImage, Video, IntensityMeasure, TimeSpentInSec) " +
                "VALUES ('https://hips.hearstapps.com/hmg-prod/images/workouts/2016/03/barbellrow-1457038583.gif'," +
                "'Barbell Bent-Over Row'," +
                "'As you’re working with a barbell, you should be able to shift more weight during a barbell bent-over row. Helping your recruit more muscle — and, obviously, elicit further muscle growth — you’ll work your middle and lower traps, rhomboid major, rhomboid minor, upper traps, rear deltoids, and rotator cuff muscles. Keep your shoulder blades back to avoid slouching, which puts undue stress on your lower back.'," +
                "0.34," +
                "'https://cdn.shopify.com/s/files/1/1633/7705/articles/bent_over_rows_2000x.jpg'," +
                "'https://www.youtube.com/watch?v=6FZHJGzMFEc'," +
                "'Kg'," +
                "3)");
            
            migrationBuilder.Sql(
                "INSERT INTO Exercises (Image, Name, Description, Calories, PresentationImage, Video, IntensityMeasure, TimeSpentInSec) " +
                "VALUES ('https://bodybuilding-wizard.com/wp-content/uploads/2014/04/close-grip-barbell-bech-press-animation-2.gif'," +
                "'Close-grip Bench Press'," +
                "'The bench press is a great tricep exercise to work your chest and core. Placing your hands closer together makes it so your triceps have to work harder, which can lead to new growth and more strength.'," +
                "0.27," +
                "'https://garagegympro.com/wp-content/uploads/2022/03/GGP-Alternatives-Custom-Images-27.png'," +
                "'https://www.youtube.com/watch?v=XEFDMwmrLAM'," +
                "'Kg'," +
                "4)");
            
            migrationBuilder.Sql(
                "INSERT INTO Exercises (Image, Name, Description, Calories, PresentationImage, Video, IntensityMeasure, TimeSpentInSec) " +
                "VALUES ('https://cdn.shopify.com/s/files/1/0162/2116/files/dips_grande.gif'," +
                "'Dips'," +
                "'Because you’re lifting your entire bodyweight, your triceps have to work against a much heavier load than they would in a triceps-isolating exercise.'," +
                "1.66," +
                "'https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/man-during-workout-in-the-gym-royalty-free-image-1597849641.jpg'," +
                "'https://www.youtube.com/watch?v=sM6XUdt1rm4'," +
                "'NotApply'," +
                "3)");
            
            migrationBuilder.Sql(
                "INSERT INTO Exercises (Image, Name, Description, Calories, PresentationImage, Video, IntensityMeasure, TimeSpentInSec) " +
                "VALUES ('https://hips.hearstapps.com/ame-prod-menshealth-assets.s3.amazonaws.com/main/assets/kettlebell-floor.gif'," +
                "'One Arm Kettlebell Floor Press'," +
                "'Using one arm at a time isolates the chest and triceps, ensuring the muscles are worked hard.'," +
                "1," +
                "'https://cdn.muscleandstrength.com/sites/default/files/one-arm-kettlebell-floor-press.jpg'," +
                "'https://www.youtube.com/watch?v=y-vCsuuE-uw'," +
                "'Kg'," +
                "3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE * FROM Exercises");
        }
    }
}
