using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIwithEFCodeFirst.Model
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudID { get; set; }
        public string StudName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int Pin { get; set; }
    }
}
