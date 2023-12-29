using Microsoft.EntityFrameworkCore;
using WakeProWebApi.Models;

namespace WakeProWebApi.Contexts
{
   public class AppDbContext : DbContext
   {
      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
      {
      }

      public DbSet<User> Users { get; set; }
      public DbSet<Trick> Tricks { get; set; }
      public DbSet<TrickSubStep> TrickSubSteps { get; set; }
      public DbSet<TrickSubstepMapping> TrickSubstepMappings { get; set; }
      public DbSet<UserTrickProgress> UserTrickProgresses { get; set; }
      public DbSet<LearningPattern> LearningPatterns { get; set; }
      public DbSet<PatternTrickMapping> PatternTrickMappings { get; set; }


      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);

         // Seed Users
         modelBuilder.Entity<User>().HasData(
             new User { UserId = 1, UserName = "user1", Email = "user1@example.com", Password = "Password1" },
             new User { UserId = 2, UserName = "user2", Email = "user2@example.com", Password = "Password2" },
             new User { UserId = 3, UserName = "user3", Email = "user3@example.com", Password = "Password3" },
             new User { UserId = 4, UserName = "user4", Email = "user4@example.com", Password = "Password4" },
             new User { UserId = 5, UserName = "user5", Email = "user5@example.com", Password = "Password5" }
         );

         // Seed Tricks
         modelBuilder.Entity<Trick>().HasData(
             new Trick { TrickId = 1, Name = "Trick1", Description = "Trick 1 description", DifficultyLevel = Level.Basic, VideoUrl = "https://www.example.com/trick1" },
             new Trick { TrickId = 2, Name = "Trick2", Description = "Trick 2 description", DifficultyLevel = Level.Basic, VideoUrl = "https://www.example.com/trick2" },
             new Trick { TrickId = 3, Name = "Trick3", Description = "Trick 3 description", DifficultyLevel = Level.Intermediate, VideoUrl = "https://www.example.com/trick3" },
             new Trick { TrickId = 4, Name = "Trick4", Description = "Trick 4 description", DifficultyLevel = Level.Intermediate, VideoUrl = "https://www.example.com/trick4" },
             new Trick { TrickId = 5, Name = "Trick5", Description = "Trick 5 description", DifficultyLevel = Level.Pro, VideoUrl = "https://www.example.com/trick5" }
         );

         // Seed TrickSubSteps
         modelBuilder.Entity<TrickSubStep>().HasData(
             new TrickSubStep { TrickSubStepId = 1, Name = "SubStep_1", Description = "SubStep_1_description" },
             new TrickSubStep { TrickSubStepId = 2, Name = "SubStep_2", Description = "SubStep_2_description" },
             new TrickSubStep { TrickSubStepId = 3, Name = "SubStep_3", Description = "SubStep_3_description" },
             new TrickSubStep { TrickSubStepId = 4, Name = "SubStep_4", Description = "SubStep_4_description" },
             new TrickSubStep { TrickSubStepId = 5, Name = "SubStep_5", Description = "SubStep_5_description" }
         );

         // Seed TrickSubstepMappings
         modelBuilder.Entity<TrickSubstepMapping>().HasData(
             new TrickSubstepMapping { MappingId = 1, TrickId = 1, SubstepId = 1, Order = 0 },
             new TrickSubstepMapping { MappingId = 2, TrickId = 1, SubstepId = 2, Order = 1 },
             new TrickSubstepMapping { MappingId = 3, TrickId = 1, SubstepId = 3, Order = 2 },
             new TrickSubstepMapping { MappingId = 4, TrickId = 1, SubstepId = 4, Order = 3 },
             new TrickSubstepMapping { MappingId = 5, TrickId = 1, SubstepId = 5, Order = 4 },
             new TrickSubstepMapping { MappingId = 6, TrickId = 2, SubstepId = 1, Order = 0 },
             new TrickSubstepMapping { MappingId = 7, TrickId = 2, SubstepId = 2, Order = 1 },
             new TrickSubstepMapping { MappingId = 8, TrickId = 2, SubstepId = 3, Order = 2 },
             new TrickSubstepMapping { MappingId = 9, TrickId = 2, SubstepId = 4, Order = 3 },
             new TrickSubstepMapping { MappingId = 10, TrickId = 3, SubstepId = 5, Order = 4 },
             new TrickSubstepMapping { MappingId = 11, TrickId = 3, SubstepId = 1, Order = 0 },
             new TrickSubstepMapping { MappingId = 12, TrickId = 3, SubstepId = 2, Order = 1 },
             new TrickSubstepMapping { MappingId = 13, TrickId = 3, SubstepId = 3, Order = 2 },
             new TrickSubstepMapping { MappingId = 14, TrickId = 3, SubstepId = 4, Order = 3 },
             new TrickSubstepMapping { MappingId = 15, TrickId = 3, SubstepId = 5, Order = 4 }
         );

         // Seed UserTrickProgress
         modelBuilder.Entity<UserTrickProgress>().HasData(
             new UserTrickProgress { UserTrickProgressId = 1, UserId = 1, TrickId = 1, TrickSubStepId = 1, IsCompleted = true },
             new UserTrickProgress { UserTrickProgressId = 2, UserId = 2, TrickId = 2, TrickSubStepId = 2, IsCompleted = false },
             new UserTrickProgress { UserTrickProgressId = 3, UserId = 3, TrickId = 3, TrickSubStepId = 3, IsCompleted = false },
             new UserTrickProgress { UserTrickProgressId = 4, UserId = 4, TrickId = 4, TrickSubStepId = 4, IsCompleted = false },
             new UserTrickProgress { UserTrickProgressId = 5, UserId = 5, TrickId = 5, TrickSubStepId = 5, IsCompleted = false }
         );

         // Seed LearningPatterns
         modelBuilder.Entity<LearningPattern>().HasData(
             new LearningPattern { LearningPatternId = 1, Name = "Basic Features" },
             new LearningPattern { LearningPatternId = 2, Name = "Kicker" },
             new LearningPattern { LearningPatternId = 3, Name = "Degrees/Spins" }
         );

         // Seed PatternTrickMappings
         modelBuilder.Entity<PatternTrickMapping>().HasData(
             new PatternTrickMapping { MappingId = 1, PatternId = 1, TrickId = 1 },
             new PatternTrickMapping { MappingId = 2, PatternId = 1, TrickId = 2 },
             new PatternTrickMapping { MappingId = 3, PatternId = 2, TrickId = 2 },
             new PatternTrickMapping { MappingId = 4, PatternId = 2, TrickId = 3 },
             new PatternTrickMapping { MappingId = 5, PatternId = 2, TrickId = 4 }
         );
      }

   }
}
