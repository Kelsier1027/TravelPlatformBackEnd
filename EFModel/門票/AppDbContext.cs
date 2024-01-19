using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EFModel.門票
{
	public partial class AppDbContext : DbContext
	{
		public AppDbContext()
			: base("name=AppDbContext1")
		{
		}

		public virtual DbSet<Attraction> Attractions { get; set; }
		public virtual DbSet<AttractionsCategory> AttractionsCategories { get; set; }
		public virtual DbSet<AttractionsCity> AttractionsCities { get; set; }
		public virtual DbSet<AttractionsContent> AttractionsContents { get; set; }
		public virtual DbSet<AttractionsContentImage> AttractionsContentImages { get; set; }
		public virtual DbSet<AttractionsOrderItem> AttractionsOrderItems { get; set; }
		public virtual DbSet<AttractionsOrder> AttractionsOrders { get; set; }
		public virtual DbSet<AttractionsOrderStatu> AttractionsOrderStatus { get; set; }
		public virtual DbSet<AttractionsTicket> AttractionsTickets { get; set; }
		public virtual DbSet<AttractionsTicketStock> AttractionsTicketStocks { get; set; }
		public virtual DbSet<AttractionsTicketType> AttractionsTicketTypes { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Attraction>()
				.HasMany(e => e.AttractionsContents)
				.WithRequired(e => e.Attraction)
				.HasForeignKey(e => e.AttractionsId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Attraction>()
				.HasMany(e => e.AttractionsContentImages)
				.WithRequired(e => e.Attraction)
				.HasForeignKey(e => e.AttractionsId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Attraction>()
				.HasMany(e => e.AttractionsTickets)
				.WithRequired(e => e.Attraction)
				.HasForeignKey(e => e.AttractionsId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<AttractionsCategory>()
				.HasMany(e => e.Attractions)
				.WithRequired(e => e.AttractionsCategory)
				.HasForeignKey(e => e.Category)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<AttractionsCity>()
				.HasMany(e => e.Attractions)
				.WithRequired(e => e.AttractionsCity)
				.HasForeignKey(e => e.City)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<AttractionsContentImage>()
				.Property(e => e.Image)
				.IsUnicode(false);

			modelBuilder.Entity<AttractionsOrderItem>()
				.Property(e => e.UnitPrice)
				.HasPrecision(10, 2);

			modelBuilder.Entity<AttractionsOrder>()
				.Property(e => e.Total)
				.HasPrecision(10, 2);

			modelBuilder.Entity<AttractionsOrder>()
				.HasMany(e => e.AttractionsOrderItems)
				.WithRequired(e => e.AttractionsOrder)
				.HasForeignKey(e => e.OrderId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<AttractionsOrderStatu>()
				.HasMany(e => e.AttractionsOrders)
				.WithRequired(e => e.AttractionsOrderStatu)
				.HasForeignKey(e => e.StatusId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<AttractionsTicket>()
				.Property(e => e.Price)
				.HasPrecision(10, 2);

			modelBuilder.Entity<AttractionsTicket>()
				.HasMany(e => e.AttractionsOrderItems)
				.WithRequired(e => e.AttractionsTicket)
				.HasForeignKey(e => e.TicketId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<AttractionsTicket>()
				.HasMany(e => e.AttractionsTicketStocks)
				.WithRequired(e => e.AttractionsTicket)
				.HasForeignKey(e => e.TicketId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<AttractionsTicketType>()
				.HasMany(e => e.AttractionsTickets)
				.WithRequired(e => e.AttractionsTicketType)
				.HasForeignKey(e => e.TypeId)
				.WillCascadeOnDelete(false);
		}
	}
}
