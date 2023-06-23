using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(11)]
        public string Cpf { get; set; }
        [Required]
        [StringLength(127)]
        public string Nome { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [StringLength(127)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public int? Saldo { get; private set; }
        
    }
}
