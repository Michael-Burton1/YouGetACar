using Microsoft.EntityFrameworkCore;

namespace Game.Models
{
  public class GameContext : DbContext
  {
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Drawing>()
          .HasData(
              new Drawing { DrawingId = 1, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45], Kicker = 7},
              new Drawing { DrawingId = 2, Date ="1/10/21" , Type="Power Ball", Numbers= [7, 17, 48, 53, 56], Kicker = 7},
              new Drawing { DrawingId = 3, Date ="1/10/21" , Type="Power Ball", Numbers= [2, 35, 39, 47, 48], Kicker = 7},
              new Drawing { DrawingId = 4, Date ="1/10/21" , Type="Power Ball", Numbers= [32, 35, 38, 51, 52], Kicker = 7},
              new Drawing { DrawingId = 5, Date ="1/10/21" , Type="Power Ball", Numbers= [5, 8, 13, 34, 45], Kicker = 7},
              new Drawing { DrawingId = 6, Date ="1/10/21" , Type="Power Ball", Numbers= [6, 30, 44, 52, 58], Kicker = 7},
              new Drawing { DrawingId = 7, Date ="1/10/21" , Type="Power Ball", Numbers= [2, 15, 21, 35, 53], Kicker = 7},
              new Drawing { DrawingId = 8, Date ="1/10/21" , Type="Power Ball", Numbers= [7, 13, 23, 25, 33], Kicker = 7},
              new Drawing { DrawingId = 9, Date ="1/10/21" , Type="Power Ball", Numbers= [14, 15, 18, 34, 65], Kicker = 7},
              new Drawing { DrawingId = 10, Date ="1/10/21" , Type="Power Ball", Numbers= [21, 44, 50, 59, 66], Kicker = 7},
              new Drawing { DrawingId = 11, Date ="1/10/21" , Type="Power Ball", Numbers= [13, 23, 39, 41, 66], Kicker = 7},
              new Drawing { DrawingId = 12, Date ="1/10/21" , Type="Power Ball", Numbers= [8, 40, 41, 51, 53], Kicker = 7},
              new Drawing { DrawingId = 13, Date ="1/10/21" , Type="Power Ball", Numbers= [9, 21, 41, 49, 56], Kicker = 7},
              new Drawing { DrawingId = 14, Date ="1/10/21" , Type="Power Ball", Numbers= [2, 40, 51, 64, 67], Kicker = 7},
              new Drawing { DrawingId = 15, Date ="1/10/21" , Type="Power Ball", Numbers= [16, 32, 48, 63, 69], Kicker = 7},
              new Drawing { DrawingId = 16, Date ="1/10/21" , Type="Power Ball", Numbers= [3, 16, 22, 34, 48], Kicker = 7},
              new Drawing { DrawingId = 17, Date ="1/10/21" , Type="Power Ball", Numbers= [30, 39, 57, 58, 60], Kicker = 7},
              new Drawing { DrawingId = 18, Date ="1/10/21" , Type="Power Ball", Numbers= [2, 20, 27, 45, 57], Kicker = 7},
              new Drawing { DrawingId = 19, Date ="1/10/21" , Type="Power Ball", Numbers= [24, 32, 36, 38, 60], Kicker = 7},
              new Drawing { DrawingId = 20, Date ="1/10/21" , Type="Power Ball", Numbers= [15, 32, 41, 60, 61], Kicker = 7},
              new Drawing { DrawingId = 21, Date ="1/10/21" , Type="Power Ball", Numbers= [13, 14, 18, 34, 65], Kicker = 7},
              new Drawing { DrawingId = 22, Date ="1/10/21" , Type="Power Ball", Numbers= [8, 23, 35, 59, 65], Kicker = 7},
              new Drawing { DrawingId = 23, Date ="1/10/21" , Type="Power Ball", Numbers= [5, 13, 35, 44, 56], Kicker = 7},
              new Drawing { DrawingId = 24, Date ="1/10/21" , Type="Power Ball", Numbers= [2, 33, 34, 60, 61], Kicker = 7},
              new Drawing { DrawingId = 25, Date ="1/10/21" , Type="Power Ball", Numbers= [5, 8, 19, 21, 24], Kicker = 7},
              new Drawing { DrawingId = 26, Date ="1/10/21" , Type="Power Ball", Numbers= [14, 47, 51, 56, 69], Kicker = 7},
              new Drawing { DrawingId = 27, Date ="1/10/21" , Type="Power Ball", Numbers= [9, 20, 29, 45, 47], Kicker = 7},
              new Drawing { DrawingId = 28, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 8, 44, 53, 67], Kicker = 7},
              new Drawing { DrawingId = 29, Date ="1/10/21" , Type="Power Ball", Numbers= [4, 20, 31, 33, 53], Kicker = 7},
              new Drawing { DrawingId = 30, Date ="1/10/21" , Type="Power Ball", Numbers= [10, 24, 26, 51, 68], Kicker = 7},
              new Drawing { DrawingId = 31, Date ="1/10/21" , Type="Power Ball", Numbers= [16, 30, 35, 39, 58], Kicker = 7},
              new Drawing { DrawingId = 32, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 23, 24, 62], Kicker = 7},
              new Drawing { DrawingId = 33, Date ="1/10/21" , Type="Power Ball", Numbers= [6, 8, 22, 39, 40], Kicker = 7},
              new Drawing { DrawingId = 34, Date ="1/10/21" , Type="Power Ball", Numbers= [7, 19, 23, 54, 60], Kicker = 7},
              new Drawing { DrawingId = 35, Date ="1/10/21" , Type="Power Ball", Numbers= [5, 39, 53, 54, 63], Kicker = 7},
              new Drawing { DrawingId = 36, Date ="1/10/21" , Type="Power Ball", Numbers= [7, 20, 40, 45, 69], Kicker = 7},
              new Drawing { DrawingId = 37, Date ="1/10/21" , Type="Power Ball", Numbers= [13, 16, 20, 35, 50], Kicker = 7},
              new Drawing { DrawingId = 38, Date ="1/10/21" , Type="Power Ball", Numbers= [19, 23, 39, 59, 68]], Kicker = 7},
              new Drawing { DrawingId = 39, Date ="1/10/21" , Type="Power Ball", Numbers= [2, 7, 15, 37, 57], Kicker = 7},
              new Drawing { DrawingId = 40, Date ="1/10/21" , Type="Power Ball", Numbers= [2, 34, 37, 46, 65], Kicker = 7},
              new Drawing { DrawingId = 41, Date ="1/10/21" , Type="Power Ball", Numbers= [18, 27, 32, 39, 67], Kicker = 7},
              new Drawing { DrawingId = 42, Date ="1/10/21" , Type="Power Ball", Numbers= [15, 40, 45, 57, 64], Kicker = 7},
              new Drawing { DrawingId = 43, Date ="1/10/21" , Type="Power Ball", Numbers= [12, 15, 34, 37, 49], Kicker = 7},
              new Drawing { DrawingId = 44, Date ="1/10/21" , Type="Power Ball", Numbers= [8, 12, 36, 46, 49], Kicker = 7},
              new Drawing { DrawingId = 45, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 24, 39, 53, 54], Kicker = 7},
              new Drawing { DrawingId = 46, Date ="1/10/21" , Type="Power Ball", Numbers= [5, 31, 33, 51, 52], Kicker = 7},
              new Drawing { DrawingId = 47, Date ="1/10/21" , Type="Power Ball", Numbers= [26, 30, 38, 57, 59], Kicker = 7},
              new Drawing { DrawingId = 48, Date ="1/10/21" , Type="Power Ball", Numbers= [7, 17, 19, 44, 67], Kicker = 7},
              new Drawing { DrawingId = 49, Date ="1/10/21" , Type="Power Ball", Numbers= [2, 4, 10, 47, 51], Kicker = 7},
              new Drawing { DrawingId = 50, Date ="1/10/21" , Type="Power Ball", Numbers= [8, 10, 18, 33, 46], Kicker = 7},
              new Drawing { DrawingId = 51, Date ="1/10/21" , Type="Power Ball", Numbers= [6, 22, 60, 62, 66], Kicker = 7},
              new Drawing { DrawingId = 52, Date ="1/10/21" , Type="Power Ball", Numbers= [24, 41, 47, 57, 66], Kicker = 7},
              new Drawing { DrawingId = 53, Date ="1/10/21" , Type="Power Ball", Numbers= [24, 31, 42, 52, 68], Kicker = 7},
              new Drawing { DrawingId = 54, Date ="1/10/21" , Type="Power Ball", Numbers= [25, 36, 55, 60, 61], Kicker = 7},
              new Drawing { DrawingId = 55, Date ="1/10/21" , Type="Power Ball", Numbers= [], Kicker = 7},
              new Drawing { DrawingId = 56, Date ="1/10/21" , Type="Power Ball", Numbers= [2, 34, 37, 46, 65], Kicker = 7},
              new Drawing { DrawingId = 57, Date ="1/10/21" , Type="Power Ball", Numbers= [2, 34, 37, 46, 65], Kicker = 7},
              new Drawing { DrawingId = 58, Date ="1/10/21" , Type="Power Ball", Numbers= [2, 34, 37, 46, 65], Kicker = 7},
              new Drawing { DrawingId = 59, Date ="1/10/21" , Type="Power Ball", Numbers= [2, 34, 37, 46, 65], Kicker = 7},
              new Drawing { DrawingId = 60, Date ="1/10/21" , Type="Power Ball", Numbers= [2, 34, 37, 46, 65], Kicker = 7},
              
          );
    }
    public GamesContext(DbContextOptions<GamesContext> options)
      : base(options)
    {
    }

    public DbSet<Drawing> Drawings { get; set; }
  }
}