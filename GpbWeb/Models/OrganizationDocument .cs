using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GpbWeb.Models
{
    public class OrganizationDocument : Entity<int>
    {
        [Column("order_index")]
        public int? Order { get; set; }

        [Column("doc_type")]
        public OrganizationDocumentType DocumentType { get; set; }
        public OrganizationDocumentGroup Group { get; set; }

        [Column("group_id")]
        public int? GroupId { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("file_name")]
        public string FileName { get; set; }

        [Column("file_length")]
        public int Size { get; set; }

        [Column("is_ext")]
        public bool IsExternalLink { get; set; }

        [Column("file_path")]
        public string Path { get; set; }

        [Column("year_num")]
        public int? Year { get; set; }

        [Column("period")]
        public string Period { get; set; }

        [Column("disabled")]
        public bool IsArchived { get; set; }

        [Column("created")]
        public DateTime CreatedAt { get; set; }

        [Column("updated")]
        public DateTime UpdatedAt { get; set; }

        [Column("uploaded")]
        public DateTime? UploadedAt { get; set; }

        [RegularExpression("([a-zA-Z0-9-]+)", ErrorMessage = "Только буквочисленные комбинации и тире")]
        [Column("http_url")]
        public string PermanentUrl { get; set; }
        public bool IsPermanent => !string.IsNullOrEmpty(PermanentUrl);
        public string HumanizeBytes()
        {
            const int bytesInKilobyte = 1024;

            const int bytesInMegabyte = 1024 * 1024;

            const string byteSymbol = "B";

            const string kilobyteSymbol = "KB";

            const string megabyteSymbol = "MB";

            var byteSize = Size;

            var kilobytes = byteSize / bytesInKilobyte;

            var megabytes = byteSize / bytesInMegabyte;

            if (Math.Abs(megabytes) >= 1)
                return string.Format("{0:F} {1}", megabytes, megabyteSymbol);

            if (Math.Abs(kilobytes) >= 1)
                return string.Format("{0:F} {1}", kilobytes, kilobyteSymbol);


            return string.Format("{0} {1}", byteSize, byteSymbol);
        }
    }
}