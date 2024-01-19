namespace EFModel.門票
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttractionsTicketStock")]
    public partial class AttractionsTicketStock
    {
        public int Id { get; set; }

        public int TicketId { get; set; }

        public int Stock { get; set; }

        public DateTime? ReserveDate { get; set; }

        public virtual AttractionsTicket AttractionsTicket { get; set; }
    }
}
