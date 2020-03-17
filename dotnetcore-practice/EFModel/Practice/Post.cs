using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetcore_practice.EFModel.Practice
{

    [Table("posts")]
    public class Post
    {
        [Key]
        public long? ID { get; set; }
        [Column("user_id")]
        public long? userID { get; set; }
        [Column]
        public string title { get; set; }
        [Column]
        public string content { get; set; }
        [Column("create_date")]
        public DateTime? createDate { get; set; } 
    }
}
