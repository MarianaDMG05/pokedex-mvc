using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Pokedex.Models;

[Table("Usuario")]
    public class Usuario
    {
        [Key]
        public string UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]

        public IdentityUser ContaUsuario  { get; set; }

        [Required]
        [StringLength(60)]
        public string Nome { get; set; }

        [DataType(DataType.Type.Data)]
        public string Descricao { get; set; }
        [Column(TypeName = "double(5,2)")]
        public double Altura { get; set; }

       
       }
