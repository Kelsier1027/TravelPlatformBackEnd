namespace EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CarModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarModel()
        {
            CarModelImages = new HashSet<CarModelImage>();
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int BrandId { get; set; }

        public int TransmissionId { get; set; }

        public int EnergyTypeId { get; set; }

        public int Seats { get; set; }

        public int FeePerDay { get; set; }

        [StringLength(50)]
        public string MainImage { get; set; }

        public int MaintenanceMileage { get; set; }

        public virtual Brand Brand { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarModelImage> CarModelImages { get; set; }

        public virtual EnergyType EnergyType { get; set; }

        public virtual Transmission Transmission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Car> Cars { get; set; }
    }
}
