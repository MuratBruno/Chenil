using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Chenil.Models.MetierDBO;

namespace Chenil.Models.DonneeDAO
{

    /// <summary>
    /// Classe du Message tel qu'il sera enregistré en BDD
    /// </summary>

    [Table("Message")]
    public class MessageDAO 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column]
        public string Nom { get; set; }

        [Column]
        public string Telephone { get; set; }

        [Column]
        public string Mail { get; set; }

        [Column]
        public string Contenu { get; set; }

        [Column]
        public DateTime Date { get; set; }

    }
}
