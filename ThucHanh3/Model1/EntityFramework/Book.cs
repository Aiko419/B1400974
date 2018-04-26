namespace Model1.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            Chapters = new HashSet<Chapter>();
        }

        public int BookId { get; set; }

        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(150)]
        public string AuthorName { get; set; }

        public double? Price { get; set; }

        public int? Year { get; set; }

        [StringLength(150)]
        public string CoverPage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chapter> Chapters { get; set; }
    }
}
