using System.ComponentModel.DataAnnotations;

namespace Elias.Data.Common
{
    public class BaseEntity<T>
    {
        [Key]
        public T Id { get; set; }
        public string CreateDate { get; set; }
    }
}
