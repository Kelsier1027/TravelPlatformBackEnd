namespace EFModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CarOrder
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public int CarId { get; set; }

        public int AdministratorId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime StartDateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EndDateTime { get; set; }

        public int Total { get; set; }

        public int CarOrderStateId { get; set; }

        public virtual CarOrderStatus CarOrderStatus { get; set; }

        public virtual Car Car { get; set; }
    }
}
