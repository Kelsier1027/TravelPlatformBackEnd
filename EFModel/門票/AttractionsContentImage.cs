namespace EFModel.門票
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttractionsContentImage")]
    public partial class AttractionsContentImage
    {
        public int Id { get; set; }

        public int AttractionsId { get; set; }

        [Required]
        public string Image { get; set; }

        public string Description { get; set; }

        public virtual Attraction Attraction { get; set; }
    }
}
