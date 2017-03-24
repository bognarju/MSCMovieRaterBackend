namespace MSCMovieRaterBackend.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rate")]
    public partial class Rate
    {
        [StringLength(255)]
        public string id { get; set; }

        public string movieId { get; set; }

        public double? value { get; set; }
    }
}
