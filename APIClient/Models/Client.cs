//********************************************************************
// Criação do arquivo Client
//********************************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIClient.Models
{
    /// <summary>
    /// classe representativa da tabela Client
    /// </summary>
    [Table("Client")]
    public class Client
    {
        /// <summary>
        /// ID do cliente
        /// </summary>
        [Key]
        public int ClientID { get; set; }

        /// <summary>
        /// Nome do cliente
        /// </summary>
        [MaxLength(50,ErrorMessage = "O campo Nome suporta apenas {1} caracteres")]
        public string Nome { get; set; }

        /// <summary>
        /// Email do cliente
        /// </summary>
        [MaxLength(100,ErrorMessage = "O campo Email suporta apenas {1} caracteres")]
        public string Email { get; set; }

        /// <summary>
        /// Situação do cliente
        /// </summary>
        public bool Ativo { get; set; }
    }
}
