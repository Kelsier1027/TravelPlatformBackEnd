namespace EFModel.門票
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AttractionsOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AttractionsOrder()
        {
            AttractionsOrderItems = new HashSet<AttractionsOrderItem>();
        }

        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal Total { get; set; }

        public int StatusId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttractionsOrderItem> AttractionsOrderItems { get; set; }

        public virtual AttractionsOrderStatu AttractionsOrderStatu { get; set; }
    }
}
