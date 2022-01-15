using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SyncronApi.Model
{
    [Table("User")]
    public class User
    {
        public User(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
        [Key]
        public Guid Id { get; set; }
        [Column("Name",TypeName="ntext")]
        [MaxLength(50)]
        public string Name { get; set; }
       

    }
}
