using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elias.Data.Common
{
    public class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
