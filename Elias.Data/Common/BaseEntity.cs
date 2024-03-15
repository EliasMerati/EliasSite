using System.ComponentModel.DataAnnotations;

namespace Elias.Data.Common
{
    public class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
