using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMvc.Models
{
    //[Table("Department")]
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
