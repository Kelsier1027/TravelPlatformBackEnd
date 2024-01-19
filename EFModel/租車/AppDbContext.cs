using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EFModel
{
	public partial class AppDbContext : DbContext
	{
		public AppDbContext()
			: base("name=AppDbContext")
		{
		}

		public virtual DbSet<Brand> Brands { get; set; }
		public virtual DbSet<CarModelImage> CarModelImages { get; set; }
		public virtual DbSet<CarModel> CarModels { get; set; }
		public virtual DbSet<CarOrder> CarOrders { get; set; }
		public virtual DbSet<CarOrderStatus> CarOrderStatuses { get; set; }
		public virtual DbSet<Car> Cars { get; set; }
		public virtual DbSet<CarStatus> CarStatuses { get; set; }
		public virtual DbSet<EnergyType> EnergyTypes { get; set; }
		public virtual DbSet<Transmission> Transmissions { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Brand>()
				.HasMany(e => e.CarModels)
				.WithRequired(e => e.Brand)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<CarModel>()
				.HasMany(e => e.CarModelImages)
				.WithRequired(e => e.CarModel)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<CarModel>()
				.HasMany(e => e.Cars)
				.WithRequired(e => e.CarModel)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<CarOrderStatus>()
				.HasMany(e => e.CarOrders)
				.WithRequired(e => e.CarOrderStatus)
				.HasForeignKey(e => e.CarOrderStateId)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Car>()
				.HasMany(e => e.CarOrders)
				.WithRequired(e => e.Car)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<CarStatus>()
				.HasMany(e => e.Cars)
				.WithRequired(e => e.CarStatus)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<EnergyType>()
				.HasMany(e => e.CarModels)
				.WithRequired(e => e.EnergyType)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Transmission>()
				.HasMany(e => e.CarModels)
				.WithRequired(e => e.Transmission)
				.WillCascadeOnDelete(false);
		}
	}
}
