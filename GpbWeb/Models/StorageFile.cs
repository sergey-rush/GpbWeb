using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GpbWeb.Models
{
    public class StorageFile : Entity<string>
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("file_path")]
        public string Path { get; set; }

        [Column("file_length")]
        public long Length { get; set; }
    }
}