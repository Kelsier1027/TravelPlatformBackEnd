namespace EFModel.門票
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttractionsTicket")]
    public partial class AttractionsTicket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AttractionsTicket()
        {
            AttractionsOrderItems = new HashSet<AttractionsOrderItem>();
            AttractionsTicketStocks = new HashSet<AttractionsTicketStock>();
        }

        public int Id { get; set; }

        public int AttractionsId { get; set; }

        public decimal Price { get; set; }

        public int Discount { get; set; }

        public int TypeId { get; set; }

        public bool TicketStatus { get; set; }

        public virtual Attraction Attraction { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttractionsOrderItem> AttractionsOrderItems { get; set; }

        public virtual AttractionsTicketType AttractionsTicketType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttractionsTicketStock> AttractionsTicketStocks { get; set; }
    }
}
