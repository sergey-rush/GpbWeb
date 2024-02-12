using System.ComponentModel.DataAnnotations.Schema;

namespace GpbWeb.Models
{
    public class OrganizationDocumentGroup : Entity<int>
    {
        [Column("title")]
        public string Title { get; set; }

        [Column("doc_type")]
        public OrganizationDocumentType Type { get; set; }
    }
}