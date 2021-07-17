using Microsoft.EntityFrameworkCore;

namespace Game.Models
{
  public class GameContext : DbContext
  {
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Drawing>()
          .HasData(
              new Drawing { DrawingId = 1, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 2, Date ="1/10/21" , Type="Power Ball", Numbers= [7, 17, 48, 53, 56 ], Kicker = 7},
              new Drawing { DrawingId = 3, Date ="1/10/21" , Type="Power Ball", Numbers= [2, 35, 39, 47, 48 ], Kicker = 7},
              new Drawing { DrawingId = 4, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 5, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 6, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 7, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 8, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 9, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 10, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 11, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 12, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 13, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 14, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 15, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 16, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 17, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 18, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 19, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 20, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 21, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 22, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 23, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 24, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 25, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 26, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 27, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 28, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 29, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              new Drawing { DrawingId = 30, Date ="1/10/21" , Type="Power Ball", Numbers= [1, 5, 17, 22, 45, ], Kicker = 7},
              
          );
    }
    public GamesContext(DbContextOptions<GamesContext> options)
      : base(options)
    {
    }

    public DbSet<Drawing> Drawings { get; set; }
  }
}