namespace GestionHotel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("archive.employes")]
    public partial class employe
    {
        [StringLength(255)]
        public string lastname { get; set; }

        [StringLength(255)]
        public string firstname { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string psswrd { get; set; }

        public int id { get; set; }
    }
}
