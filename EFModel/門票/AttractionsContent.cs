namespace EFModel.門票
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttractionsContent")]
    public partial class AttractionsContent
    {
        public int Id { get; set; }

        public int AttractionsId { get; set; }

        [Required]
        public string Context { get; set; }

        public virtual Attraction Attraction { get; set; }
    }
}
