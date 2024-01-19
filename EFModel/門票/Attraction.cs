namespace EFModel.門票
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Attraction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Attraction()
        {
            AttractionsContents = new HashSet<AttractionsContent>();
            AttractionsContentImages = new HashSet<AttractionsContentImage>();
            AttractionsTickets = new HashSet<AttractionsTicket>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        public int Category { get; set; }

        public int City { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }

        public int PackageId { get; set; }

        public virtual AttractionsCategory AttractionsCategory { get; set; }

        public virtual AttractionsCity AttractionsCity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttractionsContent> AttractionsContents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttractionsContentImage> AttractionsContentImages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttractionsTicket> AttractionsTickets { get; set; }
    }
}
