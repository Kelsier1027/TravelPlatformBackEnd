namespace EFModel.門票
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AttractionsOrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int TicketId { get; set; }

        public int Qty { get; set; }

        public decimal UnitPrice { get; set; }

        public virtual AttractionsOrder AttractionsOrder { get; set; }

        public virtual AttractionsTicket AttractionsTicket { get; set; }
    }
}
