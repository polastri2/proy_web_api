using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proy_web_api.Models
{
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public string document_number { get; set; }
        [Required]
        public int salary { get; set; }
        public int age { get; set; }
        public string profile { get; set; }
        public DateTime admission_date { get; set; }

    }
}
