using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyFirstApi.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }        
        public string Name { get; set; }
        public int OrderNumber { get; set; }
       
    }
}