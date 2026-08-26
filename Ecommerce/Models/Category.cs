using Ecommerce.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(30)")]
        [MinLength(3)]
        public string Name { get; set; }

        [EnumDataType(typeof(CategoryStatus))]
        public CategoryStatus status { get; set; }


    }
}
